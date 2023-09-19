﻿using desafio_api_cadastro.Dto;
using desafio_api_cadastro.Models;

namespace desafio_api_cadastro.Repository
{
    public interface IuserRepository
    {
        User GetUserById(int id);
        User GetUsuarioPorLoginSenha(string email, string password);
        public void Save(UserDto user);

        public bool verificateEmail(string email);
    }
}
