using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Audioplayer
{
    public class SqlCaller
    {
        public SqlCaller()
        {
        }

        public DataTable GetAllPlaylist()
        {
            DataTable result = new DataTable();
            DataRow dr;
            result.Columns.Add("ID", typeof(int));
            result.Columns.Add("Name", typeof(string));
            int i = 0;
            using (var db = new DbContextModel())
            {
                var query = from p in db.Playlists
                            select p;
                foreach (var item in query)
                {
                    dr = result.NewRow();
                    result.Rows.Add(dr);
                    result.Rows[i][0] = item.ID;
                    result.Rows[i][1] = item.Name;
                    i++;
                }
            }
            return result;
        }

        public void addPlaylist(string input)
        {
                using (var db = new DbContextModel())
                {
                    var PlaylistName = input;
                    var PList = new Playlists { Name = PlaylistName };
                    db.Playlists.Add(PList);
                    db.SaveChanges();
                }
        }
        public List<string> GetAllSongs()
        {
            List<string> songs = new List<string>();
            using (var db = new DbContextModel())
            {
                var query = from p in db.Nummers
                            select p;
                foreach (var item in query)
                {
                    songs.Add(item.Path);
                }
            }
            return songs;
        }
        public List<int> GetAllPlaylistSongsId(int _ID)
        {
            List<int> songs = new List<int>();
            using (var db = new DbContextModel())
            {
                var query = from p in db.PlaylistInhoud
                            where p.Playlist_ID == _ID
                            select p;
                foreach (var item in query)
                {
                    songs.Add(item.Nummer_ID);
                }
            }
            return songs;
        }
        public List<string> GetSongNameById(List<int> _ID)
        {
            List<string> url = new List<string>();
            foreach (var item in _ID)
            {
                using (var db = new DbContextModel())
                {
                    if (item == 0)
                    {
                        continue;
                    }
                    else
                    {
                        Nummers nummer = db.Nummers.Where(n => n.ID == item).SingleOrDefault();
                        url.Add(nummer.Path);
                    }
                }
            }
            return url;
        }
        public void UploadFiles(FileDialog dialog)
        {
            for (int i = 0; i < dialog.FileNames.Length; i++)
            {
                System.Diagnostics.Debug.WriteLine(dialog.FileNames[i]);
                using (var db = new DbContextModel())
                {
                    var path = new Nummers { Path = dialog.FileNames[i] };
                    db.Nummers.Add(path);
                    db.SaveChanges();
                }
            }
        }
        public void UpdatePlaylistName(string _name, int _ID)
        {
            using (var db = new DbContextModel())
            {
                Playlists UpdatePlaylistItem = db.Playlists.SingleOrDefault(i => i.ID == _ID);
                UpdatePlaylistItem.Name = _name;
                db.SaveChanges();
            }
        }
        public void AddSongsToPlayList(int _playListID, List<string> _url)
        {
            foreach (int item in GetSongIdsByName(_url))
            {
                using (var db = new DbContextModel())
                {
                    var PListID = new PlaylistInhoud { Playlist_ID = _playListID, Nummer_ID = item };
                    db.PlaylistInhoud.Add(PListID);
                    db.SaveChanges();
                }
            }
        }
        public List<int> GetSongIdsByName(List<string> _url)
        {
            List<int> songs = new List<int>();
            foreach (string item in _url)
            {
                using (var db = new DbContextModel())
                {
                    Nummers nummer = db.Nummers.Where(n => n.Path == item).SingleOrDefault();
                    songs.Add(nummer.ID);
                    db.SaveChanges();
                }
            }
            return songs;
        }
        public void DeleteSongFromPlatlist(List<int> _url)
        {
            foreach (var item in _url)
            {
                using (var db = new DbContextModel())
                {
                    PlaylistInhoud DelteNummerItem = db.PlaylistInhoud.SingleOrDefault(i => i.Nummer_ID == item);
                    if (DelteNummerItem != null)
                    {
                        db.PlaylistInhoud.Remove(DelteNummerItem);
                        db.SaveChanges();
                    }
                }
            }
        }
        public void DeletePlaylist(int _PlaylistId)
        {
            using (var db = new DbContextModel())
            {
                Playlists playlist = db.Playlists.Where(n => n.ID == _PlaylistId).SingleOrDefault();
                db.Playlists.Remove(playlist);
            }
        }
        public int GetPlaylistIDByName(string _name)
        {
            int Id = 0;
            using (var db = new DbContextModel())
            {
                Playlists playlist = db.Playlists.Where(n => n.Name == _name).SingleOrDefault();
                Id = playlist.ID;
            }
            return Id;
        }

        public int GetNumberOfSongs(String Path)
        {
            using (var db = new DbContextModel())
            {
                Nummers nummers = db.Nummers.Where(p => p.Path == Path).SingleOrDefault();
                if(nummers != null)
                {
                    return 1;
                }
                else 
                {
                    return 0;
                }
            }
        }

    }
}

