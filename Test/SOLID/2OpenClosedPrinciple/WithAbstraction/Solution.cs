using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.SOLID._2OpenClosedPrinciple.WithAbstraction {
	internal abstract class AbstractEntity {
	}

	class RoleEntity : AbstractEntity {

	}
	class AccountEntity : AbstractEntity {
	}

	interface IRepository<in T> where T: AbstractEntity {
		void Save( T entity );

	}

	class AccountRepository : IRepository<AccountEntity> {
		public void Save( AccountEntity entity ) {			 
		}
	}

	class RoleRepository : IRepository<RoleEntity> {
		public void Save( RoleEntity entity ) {
			 
		}
	}
}
