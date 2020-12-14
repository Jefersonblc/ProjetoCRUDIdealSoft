﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace WpfClient.CRUDAPI.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    public partial class Pessoa
    {
        /// <summary>
        /// Initializes a new instance of the Pessoa class.
        /// </summary>
        public Pessoa() { }

        /// <summary>
        /// Initializes a new instance of the Pessoa class.
        /// </summary>
        public Pessoa(int id, string nome = default(string), string sobrenome = default(string), string telefone = default(string))
        {
            Id = id;
            Nome = nome;
            Sobrenome = sobrenome;
            Telefone = telefone;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "nome")]
        public string Nome { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sobrenome")]
        public string Sobrenome { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "telefone")]
        public string Telefone { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}
