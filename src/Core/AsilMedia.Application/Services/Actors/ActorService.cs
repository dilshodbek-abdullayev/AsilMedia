﻿using AsilMedia.Application.Abstractions.Repositories;
using AsilMedia.Application.DataTransferObjects;
using AsilMedia.Domain.Entities;

namespace AsilMedia.Application.Services.Actors
{
    public class ActorService : IActorService
    {
        private readonly IActorRepository _actorRepository;

        public ActorService(IActorRepository actorRepository)
            => _actorRepository = actorRepository;

        public async Task<Actor> DeleteAsync(long id)
            => await _actorRepository.DeleteAsync(id);

        public async Task<List<Actor>> SelectAllAsync()
            => await _actorRepository.SelectAllAsync();

        public async Task<Actor> SelectByIdAsync(long id)
            => await _actorRepository.SelectByIdAsync(id);

        public async Task<Actor> InsertAsync(ActorDTO actorDTO)
        {
            Actor actor = new Actor
            {
                FirstName = actorDTO.FirstName,
                LastName = actorDTO.LastName,
                Description = actorDTO.Description,
                PhotoPath = actorDTO.PhotoPath,
                Gender = actorDTO.Gender

            };

            return await _actorRepository.InsertAsync(actor);
        }

        public async Task<Actor> UpdateAsync(ActorDTO actorDTO, long id)
        {
            Actor actor = new Actor
            {
                FirstName = actorDTO.FirstName,
                LastName = actorDTO.LastName,
                Description = actorDTO.Description,
                PhotoPath = actorDTO.PhotoPath,
                Gender = actorDTO.Gender

            };
            return await _actorRepository.UpdateAsync(actor, id);
        }
    }
}
