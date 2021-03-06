```cs
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Automaty.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Automaty.Generators.EFCoreRepositories.Sample
{
    using System;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Collections.Generic;
    using Automaty.Generators.EFCoreRepositories.Sample.Entities;

    public partial class MusicRepository : BaseRepository
    {
        public MusicRepository(IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
        }

        public virtual void AddAlbum(Album entity)
        {
            UnitOfWork.Add(entity);
        }

        public virtual void DeleteAlbum(Album entity)
        {
            UnitOfWork.Delete(entity);
        }

        public virtual void DeleteAlbums(IEnumerable<Album> entities)
        {
            foreach (Album entity in entities) UnitOfWork.Delete(entity);
        }

        public virtual ICollection<Album> GetAllAlbums()
        {
            return UnitOfWork.Set<Album>().ToList();
        }

        void LoadReference<TProperty>(Album entity, Expression<Func<Album, TProperty>> propertyExpression) where TProperty : class
        {
            UnitOfWork.LoadReference(entity, propertyExpression);
        }

        void LoadCollection<TProperty>(Album entity, Expression<Func<Album, IEnumerable<TProperty>>> propertyExpression) where TProperty : class
        {
            UnitOfWork.LoadCollection(entity, propertyExpression);
        }

        public virtual Album GetAlbumById(System.Int32 albumId)
        {
            return UnitOfWork.Set<Album>().Single(x => x.AlbumId == albumId);
        }

        public virtual Album TryGetAlbumById(System.Int32 albumId)
        {
            return UnitOfWork.Set<Album>().SingleOrDefault(x => x.AlbumId == albumId);
        }

        public virtual ICollection<Album> FilterAlbumByIds(IEnumerable<System.Int32> albumIds)
        {
            return UnitOfWork.Set<Album>().Where(x => albumIds.Contains(x.AlbumId)).ToList();
        }

        public virtual void DeleteAlbumById(System.Int32 albumId)
        {
            Album entity = UnitOfWork.Set<Album>().Single(x => x.AlbumId == albumId);

            UnitOfWork.Set<Album>().Remove(entity);
        }

        public virtual bool TryDeleteAlbumById(System.Int32 albumId)
        {
            Album entity = UnitOfWork.Set<Album>().SingleOrDefault(x => x.AlbumId == albumId);

            if (entity == null) return false;

            UnitOfWork.Set<Album>().Remove(entity);
            return true;
        }

        public virtual void DeleteAlbumByIds(IEnumerable<System.Int32> albumIds)
        {
            IEnumerable<Album> entities = UnitOfWork.Set<Album>().Where(x => albumIds.Contains(x.AlbumId));

            UnitOfWork.Set<Album>().RemoveRange(entities);
        }

        public virtual ICollection<Album> FilterAlbumByGenreId(System.Int32 genreId)
        {
            return UnitOfWork.Set<Album>().Where(x => x.GenreId == genreId).ToList();
        }

        public virtual ICollection<Album> FilterAlbumByGenreId(IEnumerable<System.Int32> genreIds)
        {
            return UnitOfWork.Set<Album>().Where(x => genreIds.Contains(x.GenreId)).ToList();
        }

        public virtual void DeleteAlbumByGenreId(System.Int32 genreId)
        {
            IEnumerable<Album> entities = UnitOfWork.Set<Album>().Where(x => x.GenreId == genreId);

            UnitOfWork.Set<Album>().RemoveRange(entities);
        }

        public virtual void DeleteAlbumByGenreId(IEnumerable<System.Int32> genreIds)
        {
            IEnumerable<Album> entities = UnitOfWork.Set<Album>().Where(x => genreIds.Contains(x.GenreId));

            UnitOfWork.Set<Album>().RemoveRange(entities);
        }

        public virtual ICollection<Album> FilterAlbumByArtistIdAndGenreId(System.Int32 artistId, System.Int32 genreId)
        {
            return UnitOfWork.Set<Album>().Where(x => x.ArtistId == artistId && x.GenreId == genreId).ToList();
        }

        public virtual ICollection<Album> FilterAlbumByArtistIdAndGenreId(IEnumerable<Tuple<System.Int32, System.Int32>> artistIdsAndGenreIds)
        {
            return UnitOfWork.Set<Album>().Where(x => artistIdsAndGenreIds.Contains(new Tuple<System.Int32, System.Int32>(x.ArtistId, x.GenreId))).ToList();
        }

        public virtual void DeleteAlbumByArtistIdAndGenreId(System.Int32 artistId, System.Int32 genreId)
        {
            IEnumerable<Album> entities = UnitOfWork.Set<Album>().Where(x => x.ArtistId == artistId && x.GenreId == genreId);

            UnitOfWork.Set<Album>().RemoveRange(entities);
        }

        public virtual void DeleteAlbumByArtistIdAndGenreId(IEnumerable<Tuple<System.Int32, System.Int32>> artistIdsAndGenreIds)
        {
            IEnumerable<Album> entities = UnitOfWork.Set<Album>().Where(x => artistIdsAndGenreIds.Contains(new Tuple<System.Int32, System.Int32>(x.ArtistId, x.GenreId)));

            UnitOfWork.Set<Album>().RemoveRange(entities);
        }

        public virtual ICollection<Album> FilterAlbumByArtistId(System.Int32 artistId)
        {
            return UnitOfWork.Set<Album>().Where(x => x.ArtistId == artistId).ToList();
        }

        public virtual ICollection<Album> FilterAlbumByArtistId(IEnumerable<System.Int32> artistIds)
        {
            return UnitOfWork.Set<Album>().Where(x => artistIds.Contains(x.ArtistId)).ToList();
        }

        public virtual void DeleteAlbumByArtistId(System.Int32 artistId)
        {
            IEnumerable<Album> entities = UnitOfWork.Set<Album>().Where(x => x.ArtistId == artistId);

            UnitOfWork.Set<Album>().RemoveRange(entities);
        }

        public virtual void DeleteAlbumByArtistId(IEnumerable<System.Int32> artistIds)
        {
            IEnumerable<Album> entities = UnitOfWork.Set<Album>().Where(x => artistIds.Contains(x.ArtistId));

            UnitOfWork.Set<Album>().RemoveRange(entities);
        }

        public virtual ICollection<Album> FilterAlbumByAlbumArtUrl(System.String albumArtUrl)
        {
            return UnitOfWork.Set<Album>().Where(x => x.AlbumArtUrl == albumArtUrl).ToList();
        }

        public virtual ICollection<Album> FilterAlbumByAlbumArtUrl(IEnumerable<System.String> albumArtUrls)
        {
            return UnitOfWork.Set<Album>().Where(x => albumArtUrls.Contains(x.AlbumArtUrl)).ToList();
        }

        public virtual void DeleteAlbumByAlbumArtUrl(System.String albumArtUrl)
        {
            IEnumerable<Album> entities = UnitOfWork.Set<Album>().Where(x => x.AlbumArtUrl == albumArtUrl);

            UnitOfWork.Set<Album>().RemoveRange(entities);
        }

        public virtual void DeleteAlbumByAlbumArtUrl(IEnumerable<System.String> albumArtUrls)
        {
            IEnumerable<Album> entities = UnitOfWork.Set<Album>().Where(x => albumArtUrls.Contains(x.AlbumArtUrl));

            UnitOfWork.Set<Album>().RemoveRange(entities);
        }

        public virtual ICollection<Album> FilterAlbumByCreated(System.DateTime created)
        {
            return UnitOfWork.Set<Album>().Where(x => x.Created == created).ToList();
        }

        public virtual ICollection<Album> FilterAlbumByCreated(IEnumerable<System.DateTime> createds)
        {
            return UnitOfWork.Set<Album>().Where(x => createds.Contains(x.Created)).ToList();
        }

        public virtual void DeleteAlbumByCreated(System.DateTime created)
        {
            IEnumerable<Album> entities = UnitOfWork.Set<Album>().Where(x => x.Created == created);

            UnitOfWork.Set<Album>().RemoveRange(entities);
        }

        public virtual void DeleteAlbumByCreated(IEnumerable<System.DateTime> createds)
        {
            IEnumerable<Album> entities = UnitOfWork.Set<Album>().Where(x => createds.Contains(x.Created));

            UnitOfWork.Set<Album>().RemoveRange(entities);
        }

        public virtual ICollection<Album> FilterAlbumByPrice(System.Decimal price)
        {
            return UnitOfWork.Set<Album>().Where(x => x.Price == price).ToList();
        }

        public virtual ICollection<Album> FilterAlbumByPrice(IEnumerable<System.Decimal> prices)
        {
            return UnitOfWork.Set<Album>().Where(x => prices.Contains(x.Price)).ToList();
        }

        public virtual void DeleteAlbumByPrice(System.Decimal price)
        {
            IEnumerable<Album> entities = UnitOfWork.Set<Album>().Where(x => x.Price == price);

            UnitOfWork.Set<Album>().RemoveRange(entities);
        }

        public virtual void DeleteAlbumByPrice(IEnumerable<System.Decimal> prices)
        {
            IEnumerable<Album> entities = UnitOfWork.Set<Album>().Where(x => prices.Contains(x.Price));

            UnitOfWork.Set<Album>().RemoveRange(entities);
        }

        public virtual ICollection<Album> FilterAlbumByTitle(System.String title)
        {
            return UnitOfWork.Set<Album>().Where(x => x.Title == title).ToList();
        }

        public virtual ICollection<Album> FilterAlbumByTitle(IEnumerable<System.String> titles)
        {
            return UnitOfWork.Set<Album>().Where(x => titles.Contains(x.Title)).ToList();
        }

        public virtual void DeleteAlbumByTitle(System.String title)
        {
            IEnumerable<Album> entities = UnitOfWork.Set<Album>().Where(x => x.Title == title);

            UnitOfWork.Set<Album>().RemoveRange(entities);
        }

        public virtual void DeleteAlbumByTitle(IEnumerable<System.String> titles)
        {
            IEnumerable<Album> entities = UnitOfWork.Set<Album>().Where(x => titles.Contains(x.Title));

            UnitOfWork.Set<Album>().RemoveRange(entities);
        }

        public virtual void AddArtist(Artist entity)
        {
            UnitOfWork.Add(entity);
        }

        public virtual void DeleteArtist(Artist entity)
        {
            UnitOfWork.Delete(entity);
        }

        public virtual void DeleteArtists(IEnumerable<Artist> entities)
        {
            foreach (Artist entity in entities) UnitOfWork.Delete(entity);
        }

        public virtual ICollection<Artist> GetAllArtists()
        {
            return UnitOfWork.Set<Artist>().ToList();
        }

        void LoadReference<TProperty>(Artist entity, Expression<Func<Artist, TProperty>> propertyExpression) where TProperty : class
        {
            UnitOfWork.LoadReference(entity, propertyExpression);
        }

        void LoadCollection<TProperty>(Artist entity, Expression<Func<Artist, IEnumerable<TProperty>>> propertyExpression) where TProperty : class
        {
            UnitOfWork.LoadCollection(entity, propertyExpression);
        }

        public virtual Artist GetArtistById(System.Int32 artistId)
        {
            return UnitOfWork.Set<Artist>().Single(x => x.ArtistId == artistId);
        }

        public virtual Artist TryGetArtistById(System.Int32 artistId)
        {
            return UnitOfWork.Set<Artist>().SingleOrDefault(x => x.ArtistId == artistId);
        }

        public virtual ICollection<Artist> FilterArtistByIds(IEnumerable<System.Int32> artistIds)
        {
            return UnitOfWork.Set<Artist>().Where(x => artistIds.Contains(x.ArtistId)).ToList();
        }

        public virtual void DeleteArtistById(System.Int32 artistId)
        {
            Artist entity = UnitOfWork.Set<Artist>().Single(x => x.ArtistId == artistId);

            UnitOfWork.Set<Artist>().Remove(entity);
        }

        public virtual bool TryDeleteArtistById(System.Int32 artistId)
        {
            Artist entity = UnitOfWork.Set<Artist>().SingleOrDefault(x => x.ArtistId == artistId);

            if (entity == null) return false;

            UnitOfWork.Set<Artist>().Remove(entity);
            return true;
        }

        public virtual void DeleteArtistByIds(IEnumerable<System.Int32> artistIds)
        {
            IEnumerable<Artist> entities = UnitOfWork.Set<Artist>().Where(x => artistIds.Contains(x.ArtistId));

            UnitOfWork.Set<Artist>().RemoveRange(entities);
        }

        public virtual Artist GetArtistByName(System.String name)
        {
            return UnitOfWork.Set<Artist>().Single(x => x.Name == name);
        }

        public virtual Artist TryGetArtistByName(System.String name)
        {
            return UnitOfWork.Set<Artist>().SingleOrDefault(x => x.Name == name);
        }

        public virtual ICollection<Artist> FilterArtistByName(IEnumerable<System.String> names)
        {
            return UnitOfWork.Set<Artist>().Where(x => names.Contains(x.Name)).ToList();
        }

        public virtual void DeleteArtistByName(System.String name)
        {
            Artist entity = UnitOfWork.Set<Artist>().Single(x => x.Name == name);

            UnitOfWork.Set<Artist>().Remove(entity);
        }

        public virtual bool TryDeleteArtistByName(System.String name)
        {
            Artist entity = UnitOfWork.Set<Artist>().SingleOrDefault(x => x.Name == name);

            if (entity == null) return false;

            UnitOfWork.Set<Artist>().Remove(entity);
            return true;
        }

        public virtual void DeleteArtistByName(IEnumerable<System.String> names)
        {
            IEnumerable<Artist> entities = UnitOfWork.Set<Artist>().Where(x => names.Contains(x.Name));

            UnitOfWork.Set<Artist>().RemoveRange(entities);
        }

        public virtual void AddGenre(Genre entity)
        {
            UnitOfWork.Add(entity);
        }

        public virtual void DeleteGenre(Genre entity)
        {
            UnitOfWork.Delete(entity);
        }

        public virtual void DeleteGenres(IEnumerable<Genre> entities)
        {
            foreach (Genre entity in entities) UnitOfWork.Delete(entity);
        }

        public virtual ICollection<Genre> GetAllGenres()
        {
            return UnitOfWork.Set<Genre>().ToList();
        }

        void LoadReference<TProperty>(Genre entity, Expression<Func<Genre, TProperty>> propertyExpression) where TProperty : class
        {
            UnitOfWork.LoadReference(entity, propertyExpression);
        }

        void LoadCollection<TProperty>(Genre entity, Expression<Func<Genre, IEnumerable<TProperty>>> propertyExpression) where TProperty : class
        {
            UnitOfWork.LoadCollection(entity, propertyExpression);
        }

        public virtual Genre GetGenreById(System.Int32 genreId)
        {
            return UnitOfWork.Set<Genre>().Single(x => x.GenreId == genreId);
        }

        public virtual Genre TryGetGenreById(System.Int32 genreId)
        {
            return UnitOfWork.Set<Genre>().SingleOrDefault(x => x.GenreId == genreId);
        }

        public virtual ICollection<Genre> FilterGenreByIds(IEnumerable<System.Int32> genreIds)
        {
            return UnitOfWork.Set<Genre>().Where(x => genreIds.Contains(x.GenreId)).ToList();
        }

        public virtual void DeleteGenreById(System.Int32 genreId)
        {
            Genre entity = UnitOfWork.Set<Genre>().Single(x => x.GenreId == genreId);

            UnitOfWork.Set<Genre>().Remove(entity);
        }

        public virtual bool TryDeleteGenreById(System.Int32 genreId)
        {
            Genre entity = UnitOfWork.Set<Genre>().SingleOrDefault(x => x.GenreId == genreId);

            if (entity == null) return false;

            UnitOfWork.Set<Genre>().Remove(entity);
            return true;
        }

        public virtual void DeleteGenreByIds(IEnumerable<System.Int32> genreIds)
        {
            IEnumerable<Genre> entities = UnitOfWork.Set<Genre>().Where(x => genreIds.Contains(x.GenreId));

            UnitOfWork.Set<Genre>().RemoveRange(entities);
        }

        public virtual Genre GetGenreByName(System.String name)
        {
            return UnitOfWork.Set<Genre>().Single(x => x.Name == name);
        }

        public virtual Genre TryGetGenreByName(System.String name)
        {
            return UnitOfWork.Set<Genre>().SingleOrDefault(x => x.Name == name);
        }

        public virtual ICollection<Genre> FilterGenreByName(IEnumerable<System.String> names)
        {
            return UnitOfWork.Set<Genre>().Where(x => names.Contains(x.Name)).ToList();
        }

        public virtual void DeleteGenreByName(System.String name)
        {
            Genre entity = UnitOfWork.Set<Genre>().Single(x => x.Name == name);

            UnitOfWork.Set<Genre>().Remove(entity);
        }

        public virtual bool TryDeleteGenreByName(System.String name)
        {
            Genre entity = UnitOfWork.Set<Genre>().SingleOrDefault(x => x.Name == name);

            if (entity == null) return false;

            UnitOfWork.Set<Genre>().Remove(entity);
            return true;
        }

        public virtual void DeleteGenreByName(IEnumerable<System.String> names)
        {
            IEnumerable<Genre> entities = UnitOfWork.Set<Genre>().Where(x => names.Contains(x.Name));

            UnitOfWork.Set<Genre>().RemoveRange(entities);
        }

        public virtual ICollection<Genre> FilterGenreByDescription(System.String description)
        {
            return UnitOfWork.Set<Genre>().Where(x => x.Description == description).ToList();
        }

        public virtual ICollection<Genre> FilterGenreByDescription(IEnumerable<System.String> descriptions)
        {
            return UnitOfWork.Set<Genre>().Where(x => descriptions.Contains(x.Description)).ToList();
        }

        public virtual void DeleteGenreByDescription(System.String description)
        {
            IEnumerable<Genre> entities = UnitOfWork.Set<Genre>().Where(x => x.Description == description);

            UnitOfWork.Set<Genre>().RemoveRange(entities);
        }

        public virtual void DeleteGenreByDescription(IEnumerable<System.String> descriptions)
        {
            IEnumerable<Genre> entities = UnitOfWork.Set<Genre>().Where(x => descriptions.Contains(x.Description));

            UnitOfWork.Set<Genre>().RemoveRange(entities);
        }
    }
}
```
