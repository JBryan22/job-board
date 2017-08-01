using System.Collections.Generic;
namespace JobBoard.Models

{
    public class JobOpening
    {
        private string _title;
        private string _description;
        private Contact _contact;
        private int _id;
        private static List<JobOpening> _allJobs= new List<JobOpening> {};

        public JobOpening(string title,string description, Contact contact)
        {
            _title = title;
            _description = description;
            _contact = contact;
            _allJobs.Add(this);
            _id = _allJobs.Count;
        }

        public void SetTitle(string title)
        {
            _title = title;
        }
        public string GetTitle()
        {
            return _title;
        }
        public void SetDescription(string description)
        {
            _description = description;
        }
        public string GetDescription()
        {
            return _description;
        }
        public static List<JobOpening> GetAllJobs()
        {
            return _allJobs;
        }
        public void SetContact(Contact contact)
        {
            _contact = contact;
        }
        public Contact GetContact()
        {
            return _contact;
        }
        public static JobOpening Find(int searchId)
        {
            return _allJobs[searchId-1];
        }
        public int GetId()
        {
            return _id;
        }

    }
}
