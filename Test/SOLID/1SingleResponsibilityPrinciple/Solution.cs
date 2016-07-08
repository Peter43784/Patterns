using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.SOLID._1SingleResponsibilityPrinciple {
	
	interface IValidation {

		bool IsValid( Product p );

	}
	class DefaultValidator : IValidation {
	 
		public bool IsValid( Product p ) {
			return p.Price > 0;
		}

	}
	class CustomValidator : IValidation {

		public bool IsValid( Product p ) {
			return p.Price > 20;
		}

	}
	public abstract class Product {
		public int Price { get; set; }
	}

	//Althoug it does not violate SRP id does violate dependency inversion principle
	class ProductB : Product {

		
		public bool IsValid(IValidation v ) {
			return v.IsValid( this );
		}
	}
	class ProductC : Product {
	
		private readonly IValidation m_validator;

		public ProductC() : this( new DefaultValidator() ) {			
		}

		public ProductC(IValidation validator) {
			m_validator = validator;
		}
		
		public bool IsValid() {
			return m_validator.IsValid( this );
		}
	}
}
