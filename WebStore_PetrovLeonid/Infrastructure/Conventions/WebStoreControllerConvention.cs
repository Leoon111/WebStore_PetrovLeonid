using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ApplicationModels;

namespace WebStore_PetrovLeonid.Infrastructure.Conventions
{
    public class WebStoreControllerConvention : IControllerModelConvention
    {
        public void Apply(ControllerModel controller)
        {
            //controller.Actions.Add(new ActionModel());
            //controller.RouteValues["id"] = "123";
        }
    }
}
