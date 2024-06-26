using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp.Util
{

	[Serializable]
	public class SampleConsoleException : Exception
	{
		private ILogger logger = new FileLogger();
		public SampleConsoleException() { logger.LogError("Unknown Exception"); }
		public SampleConsoleException(string message) : base(message) { logger.LogError(message); }
		public SampleConsoleException(string message, Exception inner) : base(message, inner) 
		{ 
			logger.LogError(message); 
			if(inner != null)
			{
				logger.LogError(inner.Message);
			}
			else
			{
				logger.LogError("Unknow Error as no Inner Exception details are provided by the System");
			}
		}
		protected SampleConsoleException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
}
