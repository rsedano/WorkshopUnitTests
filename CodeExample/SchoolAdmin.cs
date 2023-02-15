using System;
using CodeExample.Interfaces;

namespace CodeExample
{
	public class SchoolAdmin: ISchoolAdmin
	{
        private string userName;
        private string password;
        private ISchoolBuilding building;

		public SchoolAdmin(string userName, string password, ISchoolBuilding building)
		{
            this.userName = userName;
            this.password = password;
            this.building = building;
        }

        public virtual void CloseElementsSchoolDueToAFire(List<string> elementsToClose)
        {
            foreach(var elementToClose in elementsToClose)
            {
                this.CloseElementSchoolDueToAFire(elementToClose);
            }
        }

        public virtual elementStatus CloseElementSchoolDueToAFire(string elementToClose)
        {
            // close the element with some integration
            try
            {
                var status = this.building.Close(elementToClose);
                return new elementStatus { elementName = elementToClose, status = status };
            }
            catch
            {
                return new elementStatus { elementName = elementToClose, status = "failure" };
            }
        }
    }

    public readonly record struct elementStatus(string elementName, string status);
}

