using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.SOLID._2OpenClosedPrinciple.WithoutAbstraction.Problem {

	// Breakin OP principle attracts breking SRP as well because SmtpMailer open to modification
	//We have to change code in order to change a logging logic
	class Logger {
		public void Log(string logText ) {
			
		}	 
	}
	class DataBaseLogger {
		public void Log( string logText ) {
			
		}
	}

	class SmtpMailer {

		//private DataBaseLogger logger
		private Logger logger;

		public SmtpMailer() {

			//logger = new DataBaseLogger();
			logger = new Logger();
		}

		public void SendMessage(string message) {
			
			logger.Log( "Sent: " + message );
		}
		

	}
}
