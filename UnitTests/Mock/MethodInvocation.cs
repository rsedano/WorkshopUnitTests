using System;
namespace UnitTests.Mock
{
	public class MethodInvocation
	{
		private List<Object> parameters =  new List<Object>();
		private Object returnValue = null;
		private string method;

        public List<Object> getParams()
		{
			return parameters;
		}

		public MethodInvocation addParam(Object param)
		{
			this.getParams().Add(param);
			return this;
		}

		public string getMethod()
		{
			return method;
		}

		public MethodInvocation setMethod(string method)
		{
			this.method = method;
			return this;
		}
	}
}

