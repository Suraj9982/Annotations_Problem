using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annotation
{
    class AnnotationTest
    {
        public static void Display()
        {
            Console.WriteLine("Employee class validation");
            Console.WriteLine("-------------------------");
            Employee objemployee = new Employee();
            objemployee.Name = "suraj";
            objemployee.Age = 22;
            objemployee.PhoneNumber = "999999999";
            objemployee.Email = "surajsk9982@gmail.com";
            ValidationContext context = new ValidationContext(objemployee, null, null);
            List<ValidationResult> results = new List<ValidationResult>();
            bool valid = Validator.TryValidateObject(objemployee, context, results, true);
            if (!valid)
            {
                foreach(ValidationResult totalresult in results)
                {
                    Console.Write("Member name : {0}", totalresult.MemberNames.First(), Environment.NewLine);
                    Console.Write("Error Msg ::{0}{1}",totalresult.ErrorMessage,Environment.NewLine);

                }
            }
            else
            {
                Console.WriteLine("Name: "+objemployee.Name + "\n" + "Age:"+objemployee.Age + "\n" + "Phonenumber:" + objemployee.PhoneNumber + "\n" + "EmailAddress:"+objemployee.Email);
            }
        }
    }
}
