using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.SOLID._2OpenClosedPrinciple.WithAbstraction.Problem {

	//Adding new entities into hierarchy  provides changes in Repository class
	abstract class AbstractEntity {

	}

	class RoleEntity : AbstractEntity{

	

	}
	class AccountEntity : AbstractEntity {



	}

	class Repository {
		public void Save(AbstractEntity entity ) {
			if( entity is AccountEntity ) {			
			}
			if( entity is RoleEntity ) {	
			}
		}
		

	}
}
