using Clinic;
using System.Collections;

public class ClinicBase
{
    private ArrayList Patients = new ArrayList();
    private ArrayList Doctors = new ArrayList();
    public ClinicBase() { }

    public string AddPatient(Person patient) 
    { 
        Patients.Add(patient);
        return "Be'mor qo'shildi";
    }
    public Person GetPatient(int Ssn)
    {
        foreach (Person patient in Patients)
        {
            if(patient.SSN == Ssn)
            {
                return patient;
            }
        }return null;

    }
    public string AddPatient(Doctor doctor)
    {
        Doctors.Add(doctor);
        return "Doktor qo'shildi";
    }

}