using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Entities
{
    class Animal
    {
        public int AnimalId { get; set; }
        public string NomeAnimal { get; set; }
        public DateTime DataRegistro { get; set; }
        public int ProprietarioId { get; set; }
        public string Especie { get; set; }
        public string Raca { get; set; }
        public string Identificacao { get; set; }
        public int MyProperty { get; set; }
        public string FotoUrl { get; set; }
        public string Fobias { get; set; }
        public bool DisponivelTosa { get; set; }
        public bool PossuiPedrigree { get; set; }
        public bool Agressivo { get; set; }
        public bool Hiperativo { get; set; }
        public bool Antissocial { get; set; }
        public bool Obsessivo { get; set; }

        public Animal()
        {
        }

        public Animal(int animalId, string nomeAnimal, DateTime dataRegistro, int proprietarioId, string especie, string raca, string identificacao, int myProperty, string fotoUrl, string fobias, bool disponivelTosa, bool possuiPedrigree, bool agressivo, bool hiperativo, bool antissocial, bool obsessivo)
        {
            AnimalId = animalId;
            NomeAnimal = nomeAnimal;
            DataRegistro = dataRegistro;
            ProprietarioId = proprietarioId;
            Especie = especie;
            Raca = raca;
            Identificacao = identificacao;
            MyProperty = myProperty;
            FotoUrl = fotoUrl;
            Fobias = fobias;
            DisponivelTosa = disponivelTosa;
            PossuiPedrigree = possuiPedrigree;
            Agressivo = agressivo;
            Hiperativo = hiperativo;
            Antissocial = antissocial;
            Obsessivo = obsessivo;
        }

        public void AdicionarAnimal()
        {
        }
    }
}
