using Syncfusion.Maui.Data;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace SfDataGridSample
{
    public class Employee : INotifyPropertyChanged
    {
        private int? _employeeID;
        private string? _name;
        private string? _title;

        public int? EmployeeID
        {
            get { return _employeeID; }
            set
            {
                _employeeID = value;
                OnPropertyChanged(nameof(EmployeeID));
            }
        }

        public string? Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public string? Title
        {
            get { return _title; }
            set
            {
                _title = value;
                OnPropertyChanged(nameof(Title));
            }
        }
       

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged(string name)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
    }

    public class EmployeeViewModel : IDisposable, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        private void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        public EmployeeViewModel()
        {
            employees = this.GetEmployeeDetails(30);
        }
        private ObservableCollection<Employee> employees;
        public ObservableCollection<Employee> Employees
        {
            get
            {
                return employees;
            }
            set
            {
                this.employees = value;
                NotifyPropertyChanged(nameof(Employees));
            }
        }

        Random r = new Random();
        Dictionary<string, string> loginID = new Dictionary<string, string>();
        Dictionary<string, string> gender = new Dictionary<string, string>();

        /// <summary>
        /// Get the EmployeeDetails
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        public ObservableCollection<Employee> GetEmployeeDetails(int count)
        {
            employees = new ObservableCollection<Employee>();
            for (int i = 1; i < count; i++)
            {
                var name = employeeName[r.Next(employeeName.Length - 1)];
                employees.Add(new Employee()
                {
                    EmployeeID = 1000 + i,
                    Name = name,                   
                    Title = title[r.Next(title.Length - 1)],
                });
            }

            return employees;
        }


        string[] title = new string[]
        {
            "Assistant",
            "Engineering",
            "Designer",
            "Manager",
            "WC60",
            "WC10",
            "Design Engineer",
            "WC10",
            "Vice President",
            "Stocker",
            "Master Scheduler",
            "Recruiter",
            "Maintenance Supervisor",
        };

        string[] employeeName = new string[]
        {
            "Sean Jacobson",
            "Phyllis Allen",
            "Marvin Allen",
            "Michael Allen",
            "Cecil Allison",
            "Oscar Alpuerto",
            "Sandra Altamirano",
            "Selena Alvarad",
            "Emilio Alvaro",
            "Maxwell Amland",
            "Mae Anderson",
            "Ramona Antrim",
            "Sabria Appelbaum",
            "Hannah Arakawa",
            "Kyley Arbelaez",
            "Tom Johnston",
            "Thomas Armstrong",
            "John Arthur",
            "Chris Ashton",
            "Teresa Atkinson",
            "John Ault",
            "Robert Avalos",
            "Stephen Ayers",
            "Phillip Bacalzo",
            "Gustavo Achong",
            "Catherine Abel",
            "Kim Abercrombie",
            "Humberto Acevedo",
            "Pilar Ackerman",
            "Frances Adams",
            "Margar Smith",
            "Carla Adams",
            "Jay Adams",
            "Ronald Adina",
            "Samuel Agcaoili",
            "James Aguilar",
            "Robert Ahlering",
            "Francois Ferrier",
            "Kim Akers",
            "Lili Alameda",
            "Amy Alberts",
            "Anna Albright",
            "Milton Albury",
            "Paul Alcorn",
            "Gregory Alderson",
            "J. Phillip Alexander",
            "Michelle Alexander",
            "Daniel Blanco",
            "Cory Booth",
            "James Bailey"
        };



        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool isdisposable)
        {
            if (Employees != null)
            {
                Employees.Clear();
            }
        }
    }
}
