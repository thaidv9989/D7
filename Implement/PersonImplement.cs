using D7_ASPMVC.Interfaces;
using System.Collections.Generic;
using D7_ASPMVC.Models;
namespace D7_ASPMVC.Implement{

    public class  PersonImplement : IPerson
    {
        public static List<PersonModel> people = new List<PersonModel>{
            new PersonModel{
                ID = 1,
                FirstName = "Thai",
                LastName = "Do Van",
                Gender = "Male",
                DOB = new DateTime(2001, 2, 15),
                PhoneNumber = "0989479615",
                Address = "Thai Binh"
            },
            new PersonModel{
                ID = 2,
                FirstName = "Hoc",
                LastName = "Nguyen Thai",
                Gender = "Male",
                DOB = new DateTime(2000, 2, 15),
                PhoneNumber = "0989479615",
                Address = "Ha Nam"
            },
            new PersonModel{
                ID = 3,
                FirstName = "Thanh",
                LastName = "Do Tien",
                Gender = "Male",
                DOB = new DateTime(1999, 2, 15),
                PhoneNumber = "0989479615",
                Address = "Ha Noi"
            },
            new PersonModel{
                ID = 4,
                FirstName = "Anh",
                LastName = "Do Ngoc",
                Gender = "Male",
                DOB = new DateTime(1998, 3, 11),
                PhoneNumber = "0989479615",
                Address = "Ha Noi"
            },
            new PersonModel{
                ID = 5,
                FirstName = "Duy",
                LastName = "Pham Tran",
                Gender = "Male",
                DOB = new DateTime(1998, 3, 11),
                PhoneNumber = "0989479615",
                Address = "Ha Noi"
            },
            new PersonModel{
                ID = 6,
                FirstName = "Quan",
                LastName = "Pham Dinh",
                Gender = "Male",
                DOB = new DateTime(1996, 3, 11),
                PhoneNumber = "0989479615",
                Address = "Ha Noi"
            },
            new PersonModel{
                ID = 7,
                FirstName = "Huy",
                LastName = "Nguyen Quang",
                Gender = "Female",
                DOB = new DateTime(1997, 3, 11),
                PhoneNumber = "0989479615",
                Address = "Bac Giang"
            }
        };

        public List<PersonModel> GetAll(){
            return people;
        }

        public void Add(PersonModel model){
            people.Add(model);    
                    
        }

        public void Edit(PersonModel model){            
            people[model.ID - 1] = model;          
        }


        public PersonModel Detail(int ID)
        {
         var std = people.Where(s => s.ID == ID).FirstOrDefault();
         return std;
        }

        public PersonModel Delete(int ID){
            var std = people.Where(s => s.ID == ID).FirstOrDefault();
            if(std != null){
                people.RemoveAt(ID-1);
            }
            return std;
        }
    }


}