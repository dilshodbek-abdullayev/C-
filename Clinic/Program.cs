using Clinic;
using System.Collections;

Person person = new Person("Kasal", "Bemorovich", 2,Gender.male);
Console.WriteLine(person.Gender);

ClinicBase clinicBase = new ClinicBase();
clinicBase.AddPatient(person);
Console.WriteLine(clinicBase.GetPatient(2));

