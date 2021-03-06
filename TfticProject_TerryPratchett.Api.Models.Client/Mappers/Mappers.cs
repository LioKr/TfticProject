﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C = TfticProject_TerryPratchett.Api.Models.Client;
using G = TfticProject_TerryPratchett.Api.Models.Global;

namespace TfticProject_TerryPratchett.Api.Models.Client.Mappers
{
    internal static class Mappers
    {
        internal static G.User ToGlobal(this C.User entity)
        {
            return new G.User()
            {
                UserId = entity.UserId,
                Firstname = entity.Firstname,
                Lastname = entity.Lastname,
                Email = entity.Email,
                Username = entity.Username,
                Password = entity.Password,
                Role = entity.Role
            };
        }

        internal static C.User ToClient(this G.User entity)
        {
            return new C.User(entity.UserId, entity.Firstname, entity.Lastname, entity.Email, entity.Username, entity.Password, entity.Role);           
        }


        internal static G.Book ToGlobal(this C.Book entity)
        {
            return new G.Book()
            {
                BookId = entity.BookId,
                Title = entity.Title,
                ReleaseYear = entity.ReleaseYear,
                IsDiscWorld = entity.IsDiscWorld,
                SagaName = entity.SagaName,
                LastEdit = entity.LastEdit
            };
        }
        internal static C.Book ToClient(this G.Book entity)
        {
            return new C.Book(entity.BookId, entity.Title, entity.ReleaseYear, entity.IsDiscWorld, entity.SagaName, entity.LastEdit);
        }

        internal static G.Character ToGlobal(this C.Character entity)
        {
            return new G.Character()
            {
                CharacterId = entity.CharacterId,
                Firstname = entity.Firstname,
                Lastname = entity.Lastname,
                Nickname = entity.Nickname,
                Race = entity.Race,
                Role = entity.Role,
                CharacterDescription = entity.CharacterDescription,
                LastEdit = entity.LastEdit
            };
        }
        internal static C.Character ToClient(this G.Character entity)
        {
            return new C.Character(entity.CharacterId, entity.Firstname, entity.Lastname, entity.Nickname, entity.Race, entity.Role, entity.CharacterDescription, entity.LastEdit);
        }

        internal static G.Quote ToGlobal(this C.Quote entity)
        {
            return new G.Quote()
            {
                QuoteId = entity.QuoteId,
                Content = entity.Content,
                Quote_Author = entity.Quote_Author,
                Quote_Book = entity.Quote_Book,
                LastEdit = entity.LastEdit
            };
        }
        internal static C.Quote ToClient(this G.Quote entity)
        {
            return new C.Quote(entity.QuoteId, entity.Content, entity.Quote_Author, entity.Quote_Book, entity.LastEdit);
        }

        internal static G.Person ToGlobal(this C.Person entity)
        {
            return new G.Person()
            {
                PersonId = entity.PersonId,
                Firstname = entity.Firstname,
                Lastname = entity.Lastname,
                Birthdate = entity.Birthdate,
                Deathdate = entity.Deathdate
            };
        }
        internal static C.Person ToClient(this G.Person entity)
        {
            return new C.Person(entity.PersonId, entity.Firstname, entity.Lastname, entity.Birthdate, entity.Deathdate);
        }

        internal static G.Author ToGlobal(this C.Author entity)
        {
            return new G.Author()
            {
                AuthorId = entity.AuthorId,
                Biography = entity.Biography,
                Picture = entity.Picture,
                PersonId = entity.PersonId
            };
        }
        internal static C.Author ToClient(this G.Author entity)
        {
            return new C.Author(entity.AuthorId, entity.Biography, entity.Picture, entity.PersonId);
        }

        internal static G.Saga ToGlobal(this C.Saga entity)
        {
            return new G.Saga()
            {
                SagaId = entity.SagaId,
                SagaName = entity.SagaName
            };
        }
        internal static C.Saga ToClient(this G.Saga entity)
        {
            return new C.Saga(entity.SagaId, entity.SagaName);
        }

    }
}
