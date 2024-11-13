using Aspose.Domain.Worker;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Aspose.Infrastructure.InMemoryAccess
{
    public class InMemoryContext
    {
        public List<Worker> Workers { get; }
        private const decimal SALARY = 25000;

        public InMemoryContext()
        {
            this.Workers = new List<Worker>();
            this.InitEmployeesData();
        }

        private void InitEmployeesData()
        {
            var employee1 = new Employee(new Guid("824EF106-730C-4948-BE60-B060DA8EBA5C"), "Employee 1", SALARY, new DateTime(2018, 1, 12));
            var employee2 = new Employee(new Guid("DB1F2867-8B6C-4EF0-9037-3957F94F2283"), "Employee 2", SALARY, new DateTime(2019, 2, 16));
            var employee3 = new Employee(new Guid("46BDADF8-3358-4F07-B148-EB6D39E5F032"), "Employee 3", SALARY, new DateTime(2020, 1, 3));
            var employee4 = new Employee(new Guid("4932A1DB-6C9C-417F-BACB-AFDA123ADF75"), "Employee 4", SALARY, new DateTime(2015, 12, 26));
            var employee5 = new Employee(new Guid("CCE1DA84-8EED-4831-A987-628D4BA51545"), "Employee 5", SALARY, new DateTime(2016, 10, 15));
            var employee6 = new Employee(new Guid("751F4678-6253-49B1-9605-FE54ECA95078"), "Employee 6", SALARY, new DateTime(2018, 9, 21));
            var employee7 = new Employee(new Guid("3EB558D8-E098-4382-9486-2015B40B4B9A"), "Employee 7", SALARY, new DateTime(2019, 7, 12));

            this.Workers.Add(employee1);
            this.Workers.Add(employee2);
            this.Workers.Add(employee3);
            this.Workers.Add(employee4);
            this.Workers.Add(employee5);
            this.Workers.Add(employee6);
            this.Workers.Add(employee7);

            var sales1 = new Sales(new Guid("87825AC7-0F83-40CB-87D5-57FE0BA3A408"), "Sales 1", SALARY, new DateTime(2019, 02, 17), new Worker[] { employee1, employee2 });
            this.Workers.Add(sales1);
            this.Workers.Add(new Sales(new Guid("F7CF23A8-729A-49BB-B11A-E77D4D110834"), "Sales 2", SALARY, new DateTime(2019, 06, 17), new Worker[] { employee3, employee4, sales1 }));
            this.Workers.Add(new Sales(new Guid("D8391EB1-6A53-4515-A194-FB186072786E"), "Sales 3", SALARY, new DateTime(2016, 01, 21), new Worker[] { employee5 }));

            var manager1 = new Manager(new Guid("B0C88C74-6D07-4B08-81AA-737DA6B5A20D"), "Manager 1", SALARY, new DateTime(2002, 05, 26), new Worker[] { sales1, employee6, employee7 });
            this.Workers.Add(manager1);
            this.Workers.Add(new Manager(new Guid("ACA7411B-AF12-4FC4-BFA0-004F1DA2D25E"), "Manager 2", SALARY, new DateTime(2006, 03, 7), new Worker[] { manager1 } ));
            this.Workers.Add(new Manager(new Guid("B8D0BD29-C96E-4F75-B09B-6DC434BE4EAC"), "Manager 3", SALARY, new DateTime(2007, 06, 21), new Worker[] { } ));
        }

        public Task Save()
        {
            throw new NotImplementedException();
        }
    }
}
