using Microsoft.AspNetCore.Mvc.ApplicationModels;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Last.FeatureFolders
{
    public class Featureconvention: IControllerModelConvention
    {
        public void Apply(ControllerModel controller)
        {
            var featureName = GetFeatureName(controller.ControllerType);
            controller.Properties.Add("feature", featureName);
        }

        private string GetFeatureName(TypeInfo controllerType)
        {
            string[] tokens = controllerType.FullName.Split('.');
            if (!tokens.Any(t => t == "Features")) return "";
            string featureName = tokens
                .SkipWhile(t => !t.Equals("features", StringComparison.CurrentCultureIgnoreCase))
                .Skip(1)
                .Take(1)
                .FirstOrDefault(); // lấy folder đầu tiên
            //.Aggregate("", Path.Combine); // tùy chỉnh folder
            return featureName;
        }
    }
}
