using System.Xml.Linq;
using MyGoals.Domain.Common;

namespace MyGoals.Domain.Entities
{
    public class Employee : BaseEntity
    {
        public Employee()
        {
            this.Goals = new HashSet<Goal>();
            this.Comments = new HashSet<Comment>();
            this.EmployeeRequests = new HashSet<EmployeeRequest>();
        }

        public override int Id { get; set; }
        //Табельный номер/EmployeeID
        public string TabNumber { get; set; }
        //ФИО
        public string Fio { get; set; }
        //Код должности
        public string PositionNum { get; set; }
        //Должность
        public string Position { get; set; }
        //Код департамента
        public string UnitNum { get; set; }
        //Код родительского департамента
        public string UnitParentNum { get; set; }
        //Подразделение-департамент
        public string Unit { get; set; }
        //Пол, DefaultValue = "M;Ж;", M=true;Ж=false;
        public bool Gender { get; set; }
        //Город
        public string City { get; set; }
        //Функц.менеджер ИД
        public string FuncManager { get; set; }
        //Админ.менеджер ИД
        public string AdmManager { get; set; }
        //Юнит менеджер ИД
        public string UnitManager { get; set; }
        //Менеджер
        public bool IsManager { get; set; }
        //Состояние
        public int? State { get; set; }
        //Штатный
        public bool IsStaffMember { get; set; }
        //Тип сотрудника - массой или нет
        public int? HeadOffice { get; set; }
        //Активен
        public bool IsActive { get; set; }
        //Дата рождения
        public DateTime? Birthday { get; set; }
        //Дата принятия на работу
        public DateTime? HireDate { get; set; }
        //Количество подчиненных
        public int? AmountSubordinate { get; set; }
        //Логин
        public string Login { get; set; }
        //ИД "родителя"
        public int? Parent { get; set; }
        //ИД всех "родителей", через "."
        public string Parents { get; set; }
        //Уровень подчиненности
        public int Levels { get; set; }
        //ИД менеджера LT-1 - номер блока
        public int? BlockNum { get; set; }
        public string PhotoUrl { get; set; }

        //link for DB
        public virtual ICollection<Goal> Goals { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<EmployeeRequest> EmployeeRequests { get; set; }
    }
}