﻿using AutoMapper;
using Microsoft.AspNetCore.Identity;
using UsuariosApi.Data.DTOs;
using UsuariosApi.Models;

namespace UsuariosApi.Profiles;

public class UsuarioProfile: Profile
{
    public UsuarioProfile()
    {
        CreateMap<CreateUsuarioDto, Usuario>();
        CreateMap<Usuario, IdentityUser<int>>();
    }
}