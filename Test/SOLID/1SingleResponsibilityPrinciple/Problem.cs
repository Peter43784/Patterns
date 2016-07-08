using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.SOLID._1SingleResponsibilityPrinciple {

	//The reason is that Validation logic can vary from time to time
	//so it is reasonable to move this logic
    class ProductA : Product{

		public bool IsValid => Price > 0;


	}
}
