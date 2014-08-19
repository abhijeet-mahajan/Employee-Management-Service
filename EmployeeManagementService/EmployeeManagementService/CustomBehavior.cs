using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Configuration;
using System.Web;

namespace EmployeeManagementService
{
    public class CustomBehavior :  BehaviorExtensionElement
    {
        public override Type BehaviorType
        {
            get { return typeof(ValidationBehaviour);}
        }

        protected override object CreateBehavior()
        {
            return new ValidationBehaviour();
        }
    }
}

/*
 */