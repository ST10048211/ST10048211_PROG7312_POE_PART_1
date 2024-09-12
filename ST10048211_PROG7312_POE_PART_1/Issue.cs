using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ST10048211_PROG7312_POE_PART_1
{
    public class Issue
    {
        public string Location { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string Attachment { get; set; }

        public static SinglyLinkedList<Issue> issueList = new SinglyLinkedList<Issue>();

        public Issue(string location, string category, string description, string attachment)
        {
            Location = location;
            Category = category;
            Description = description;
            Attachment = attachment;
        }

        public override string ToString()
        {
            return $"Location: {Location}, Category: {Category}, Description: {Description}, Attachment: {Attachment}";
        }

        
    }
}
