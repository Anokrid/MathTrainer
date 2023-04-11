using System.Runtime.Serialization;

namespace MathTrainer
{
    [DataContract]
    public class Notes
    {
        [DataMember]
        public string Name;
        [DataMember]
        public string Note;

        public Notes(string Name)
        {
            this.Name = Name;
        }
    }
}
