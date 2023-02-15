using System;
namespace CodeExample
{
	public interface ISchoolAdmin
	{
        public void CloseElementsSchoolDueToAFire(List<string> elementsToClose);

        public elementStatus CloseElementSchoolDueToAFire(string elementToClose);

    }
}

