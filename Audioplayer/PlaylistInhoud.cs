namespace Audioplayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PlaylistInhoud")]
    public partial class PlaylistInhoud
    {
        public int ID { get; set; }
        public int Playlist_ID { get; set; }
        public int Nummer_ID { get; set; }
    }
}
