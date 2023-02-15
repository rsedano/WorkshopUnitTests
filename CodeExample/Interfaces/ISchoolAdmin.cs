using System;
namespace CodeExample.Interfaces
{
	public interface ISchoolAdmin
	{
        public void CloseElementsSchoolDueToAFire(List<string> elementsToClose);

        public elementStatus CloseElementSchoolDueToAFire(string elementToClose);

    }
}

