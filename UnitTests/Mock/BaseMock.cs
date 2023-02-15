using System;
namespace UnitTests.Mock
{
	public class BaseMock
	{
        public Dictionary<string, List<MethodInvocation>> invocationMap = new Dictionary<string, List<MethodInvocation>>();

        public void registerCall(MethodInvocation invocation)
        {
            invocationMap.TryGetValue(invocation.getMethod(), value: out List<MethodInvocation> list);

            if (list == null)
            {
                list = new List<MethodInvocation>();
            }

            if (!list.Contains(invocation))
            {
                list.Add(invocation);
            }

            invocationMap.Add(invocation.getMethod(), list);
        }

        public int invocation(string methodName)
        {
            var list = invocationMap.Where(x => x.Key.Contains(methodName));
            //.TryGetValue(methodName, value: out List<MethodInvocation> list);

            if (list == null)
            {
                return 0;
            }

            return list.Count();
        }

        public MethodInvocation arguments(string methodName, string argument, int invocationIndex)
        {
            var methodWithArg = methodName + "-" + argument;
            var list = invocationMap.First(x => x.Key == methodWithArg);
            //.TryGetValue(methodName, value: out List<MethodInvocation> list);

            if (list.Value == null || invocationIndex > list.Value.Count)
            {
                return null;
            }

            return list.Value[invocationIndex - 1];
        }
    }
}

