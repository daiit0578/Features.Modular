
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace  NotFeature.Convention
{
    public class NotFeatureconvention : IControllerModelConvention
    {
        public void Apply(ControllerModel controller)
        {
            var featureName = GetFeatureName(controller.ControllerType);
            controller.Properties.Add("hellos", featureName);
        }

        private string GetFeatureName(TypeInfo controllerType)
        {
            string[] tokens = controllerType.FullName.Split('.');
            if (!tokens.Any(t => t == "Hellos")) return "";
            string featureName = tokens
                .SkipWhile(t => !t.Equals("hellos", StringComparison.CurrentCultureIgnoreCase))
                .Skip(1)
                .Take(1)
                .FirstOrDefault();

            return featureName;
        }
    }
}


