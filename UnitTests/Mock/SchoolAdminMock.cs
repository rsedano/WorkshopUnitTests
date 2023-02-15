using System.Reflection;

namespace UnitTests.Mock
{
	public class SchoolAdminMock: BaseMock, ISchoolAdmin
	{
        public void CloseElementsSchoolDueToAFire(List<string> elementsToClose)
        {
            var invocation = new MethodInvocation();
            invocation.addParam(elementsToClose).setMethod("CloseElementsSchoolDueToAFire");
            registerCall(invocation);

            foreach (var elementToClose in elementsToClose)
            {
                this.CloseElementSchoolDueToAFire(elementToClose);
            }
        }

        public elementStatus CloseElementSchoolDueToAFire(string elementToClose)
        {
            var invocation = new MethodInvocation();
            invocation.addParam(elementToClose).setMethod("CloseElementSchoolDueToAFire-" + elementToClose);
            registerCall(invocation);
            return new elementStatus { elementName = "elementToClose", status="closed"};
        }

    }
}

