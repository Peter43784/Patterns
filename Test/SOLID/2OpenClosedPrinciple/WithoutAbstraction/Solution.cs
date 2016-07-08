using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.SOLID._2OpenClosedPrinciple.WithoutAbstraction {
	
	//Make our SmtpMailer depend on abstraction
	interface ILogger {
		void Log( string text );
	}

	class Logger : ILogger {
		public void Log( string text ) {
			 
		}
	}
	class DataBaseLogger : ILogger {
		public void Log( string text ) {

		}
	}

	class SmtpMailer {
		private readonly ILogger m_logger;

		public SmtpMailer(ILogger logger) {
			m_logger = logger;
		}
		public void SendMessage(string message ) {
			m_logger.Log( "Sent: " + message );
		}
		

	}
}
