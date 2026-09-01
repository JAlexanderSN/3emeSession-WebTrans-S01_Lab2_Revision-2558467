using System.ComponentModel.DataAnnotations;

namespace ZombieParty.Models
{
    public class ZombieType
    {
        // Champs

        public int m_Id;
        
        public string m_TypeName;

        
        // Propiétés

        public int Id
        {
            get
            {
                return m_Id;
            }

            set
            {
                m_Id = value;
            }
        }


        [Required(ErrorMessage = "Type Name has to be filled.")]
        public string TypeName
        {
            get
            {
                return m_TypeName;
            }

            set
            {
                m_TypeName = value;
            }
        }

        

    }
}
