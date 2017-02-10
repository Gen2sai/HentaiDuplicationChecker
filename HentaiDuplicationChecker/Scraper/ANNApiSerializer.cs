using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Scraper
{
    #region
    ///// <remarks/>
    //[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    //[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    //public partial class ann
    //{

    //    private annAnime animeField;

    //    /// <remarks/>
    //    public annAnime anime
    //    {
    //        get
    //        {
    //            return this.animeField;
    //        }
    //        set
    //        {
    //            this.animeField = value;
    //        }
    //    }
    //}

    ///// <remarks/>
    //[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    //public partial class annAnime
    //{

    //    private annAnimeRelatedprev relatedprevField;

    //    private annAnimeInfo[] infoField;

    //    private annAnimeRatings ratingsField;

    //    private annAnimeEpisode[] episodeField;

    //    private annAnimeStaff staffField;

    //    private annAnimeCredit[] creditField;

    //    private ushort idField;

    //    private uint gidField;

    //    private string typeField;

    //    private string nameField;

    //    private string precisionField;

    //    private System.DateTime generatedonField;

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlElementAttribute("related-prev")]
    //    public annAnimeRelatedprev relatedprev
    //    {
    //        get
    //        {
    //            return this.relatedprevField;
    //        }
    //        set
    //        {
    //            this.relatedprevField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlElementAttribute("info")]
    //    public annAnimeInfo[] info
    //    {
    //        get
    //        {
    //            return this.infoField;
    //        }
    //        set
    //        {
    //            this.infoField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    public annAnimeRatings ratings
    //    {
    //        get
    //        {
    //            return this.ratingsField;
    //        }
    //        set
    //        {
    //            this.ratingsField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlElementAttribute("episode")]
    //    public annAnimeEpisode[] episode
    //    {
    //        get
    //        {
    //            return this.episodeField;
    //        }
    //        set
    //        {
    //            this.episodeField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    public annAnimeStaff staff
    //    {
    //        get
    //        {
    //            return this.staffField;
    //        }
    //        set
    //        {
    //            this.staffField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlElementAttribute("credit")]
    //    public annAnimeCredit[] credit
    //    {
    //        get
    //        {
    //            return this.creditField;
    //        }
    //        set
    //        {
    //            this.creditField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlAttributeAttribute()]
    //    public ushort id
    //    {
    //        get
    //        {
    //            return this.idField;
    //        }
    //        set
    //        {
    //            this.idField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlAttributeAttribute()]
    //    public uint gid
    //    {
    //        get
    //        {
    //            return this.gidField;
    //        }
    //        set
    //        {
    //            this.gidField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlAttributeAttribute()]
    //    public string type
    //    {
    //        get
    //        {
    //            return this.typeField;
    //        }
    //        set
    //        {
    //            this.typeField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlAttributeAttribute()]
    //    public string name
    //    {
    //        get
    //        {
    //            return this.nameField;
    //        }
    //        set
    //        {
    //            this.nameField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlAttributeAttribute()]
    //    public string precision
    //    {
    //        get
    //        {
    //            return this.precisionField;
    //        }
    //        set
    //        {
    //            this.precisionField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlAttributeAttribute("generated-on")]
    //    public System.DateTime generatedon
    //    {
    //        get
    //        {
    //            return this.generatedonField;
    //        }
    //        set
    //        {
    //            this.generatedonField = value;
    //        }
    //    }
    //}

    ///// <remarks/>
    //[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    //public partial class annAnimeRelatedprev
    //{

    //    private string relField;

    //    private ushort idField;

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlAttributeAttribute()]
    //    public string rel
    //    {
    //        get
    //        {
    //            return this.relField;
    //        }
    //        set
    //        {
    //            this.relField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlAttributeAttribute()]
    //    public ushort id
    //    {
    //        get
    //        {
    //            return this.idField;
    //        }
    //        set
    //        {
    //            this.idField = value;
    //        }
    //    }
    //}

    ///// <remarks/>
    //[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    //public partial class annAnimeInfo
    //{

    //    private annAnimeInfoImg imgField;

    //    private string[] textField;

    //    private uint gidField;

    //    private bool gidFieldSpecified;

    //    private string typeField;

    //    private string srcField;

    //    private byte widthField;

    //    private bool widthFieldSpecified;

    //    private byte heightField;

    //    private bool heightFieldSpecified;

    //    private string langField;

    //    private string hrefField;

    //    /// <remarks/>
    //    public annAnimeInfoImg img
    //    {
    //        get
    //        {
    //            return this.imgField;
    //        }
    //        set
    //        {
    //            this.imgField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlTextAttribute()]
    //    public string[] Text
    //    {
    //        get
    //        {
    //            return this.textField;
    //        }
    //        set
    //        {
    //            this.textField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlAttributeAttribute()]
    //    public uint gid
    //    {
    //        get
    //        {
    //            return this.gidField;
    //        }
    //        set
    //        {
    //            this.gidField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlIgnoreAttribute()]
    //    public bool gidSpecified
    //    {
    //        get
    //        {
    //            return this.gidFieldSpecified;
    //        }
    //        set
    //        {
    //            this.gidFieldSpecified = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlAttributeAttribute()]
    //    public string type
    //    {
    //        get
    //        {
    //            return this.typeField;
    //        }
    //        set
    //        {
    //            this.typeField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlAttributeAttribute()]
    //    public string src
    //    {
    //        get
    //        {
    //            return this.srcField;
    //        }
    //        set
    //        {
    //            this.srcField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlAttributeAttribute()]
    //    public byte width
    //    {
    //        get
    //        {
    //            return this.widthField;
    //        }
    //        set
    //        {
    //            this.widthField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlIgnoreAttribute()]
    //    public bool widthSpecified
    //    {
    //        get
    //        {
    //            return this.widthFieldSpecified;
    //        }
    //        set
    //        {
    //            this.widthFieldSpecified = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlAttributeAttribute()]
    //    public byte height
    //    {
    //        get
    //        {
    //            return this.heightField;
    //        }
    //        set
    //        {
    //            this.heightField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlIgnoreAttribute()]
    //    public bool heightSpecified
    //    {
    //        get
    //        {
    //            return this.heightFieldSpecified;
    //        }
    //        set
    //        {
    //            this.heightFieldSpecified = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlAttributeAttribute()]
    //    public string lang
    //    {
    //        get
    //        {
    //            return this.langField;
    //        }
    //        set
    //        {
    //            this.langField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlAttributeAttribute()]
    //    public string href
    //    {
    //        get
    //        {
    //            return this.hrefField;
    //        }
    //        set
    //        {
    //            this.hrefField = value;
    //        }
    //    }
    //}

    ///// <remarks/>
    //[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    //public partial class annAnimeInfoImg
    //{

    //    private string srcField;

    //    private byte widthField;

    //    private byte heightField;

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlAttributeAttribute()]
    //    public string src
    //    {
    //        get
    //        {
    //            return this.srcField;
    //        }
    //        set
    //        {
    //            this.srcField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlAttributeAttribute()]
    //    public byte width
    //    {
    //        get
    //        {
    //            return this.widthField;
    //        }
    //        set
    //        {
    //            this.widthField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlAttributeAttribute()]
    //    public byte height
    //    {
    //        get
    //        {
    //            return this.heightField;
    //        }
    //        set
    //        {
    //            this.heightField = value;
    //        }
    //    }
    //}

    ///// <remarks/>
    //[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    //public partial class annAnimeRatings
    //{

    //    private byte nb_votesField;

    //    private decimal weighted_scoreField;

    //    private decimal bayesian_scoreField;

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlAttributeAttribute()]
    //    public byte nb_votes
    //    {
    //        get
    //        {
    //            return this.nb_votesField;
    //        }
    //        set
    //        {
    //            this.nb_votesField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlAttributeAttribute()]
    //    public decimal weighted_score
    //    {
    //        get
    //        {
    //            return this.weighted_scoreField;
    //        }
    //        set
    //        {
    //            this.weighted_scoreField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlAttributeAttribute()]
    //    public decimal bayesian_score
    //    {
    //        get
    //        {
    //            return this.bayesian_scoreField;
    //        }
    //        set
    //        {
    //            this.bayesian_scoreField = value;
    //        }
    //    }
    //}

    ///// <remarks/>
    //[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    //public partial class annAnimeEpisode
    //{

    //    private annAnimeEpisodeTitle[] titleField;

    //    private byte numField;

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlElementAttribute("title")]
    //    public annAnimeEpisodeTitle[] title
    //    {
    //        get
    //        {
    //            return this.titleField;
    //        }
    //        set
    //        {
    //            this.titleField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlAttributeAttribute()]
    //    public byte num
    //    {
    //        get
    //        {
    //            return this.numField;
    //        }
    //        set
    //        {
    //            this.numField = value;
    //        }
    //    }
    //}

    ///// <remarks/>
    //[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    //public partial class annAnimeEpisodeTitle
    //{

    //    private uint gidField;

    //    private string langField;

    //    private string partField;

    //    private string valueField;

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlAttributeAttribute()]
    //    public uint gid
    //    {
    //        get
    //        {
    //            return this.gidField;
    //        }
    //        set
    //        {
    //            this.gidField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlAttributeAttribute()]
    //    public string lang
    //    {
    //        get
    //        {
    //            return this.langField;
    //        }
    //        set
    //        {
    //            this.langField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlAttributeAttribute()]
    //    public string part
    //    {
    //        get
    //        {
    //            return this.partField;
    //        }
    //        set
    //        {
    //            this.partField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlTextAttribute()]
    //    public string Value
    //    {
    //        get
    //        {
    //            return this.valueField;
    //        }
    //        set
    //        {
    //            this.valueField = value;
    //        }
    //    }
    //}

    ///// <remarks/>
    //[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    //public partial class annAnimeStaff
    //{

    //    private string taskField;

    //    private annAnimeStaffPerson personField;

    //    private uint gidField;

    //    /// <remarks/>
    //    public string task
    //    {
    //        get
    //        {
    //            return this.taskField;
    //        }
    //        set
    //        {
    //            this.taskField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    public annAnimeStaffPerson person
    //    {
    //        get
    //        {
    //            return this.personField;
    //        }
    //        set
    //        {
    //            this.personField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlAttributeAttribute()]
    //    public uint gid
    //    {
    //        get
    //        {
    //            return this.gidField;
    //        }
    //        set
    //        {
    //            this.gidField = value;
    //        }
    //    }
    //}

    ///// <remarks/>
    //[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    //public partial class annAnimeStaffPerson
    //{

    //    private uint idField;

    //    private string valueField;

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlAttributeAttribute()]
    //    public uint id
    //    {
    //        get
    //        {
    //            return this.idField;
    //        }
    //        set
    //        {
    //            this.idField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlTextAttribute()]
    //    public string Value
    //    {
    //        get
    //        {
    //            return this.valueField;
    //        }
    //        set
    //        {
    //            this.valueField = value;
    //        }
    //    }
    //}

    ///// <remarks/>
    //[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    //public partial class annAnimeCredit
    //{

    //    private string taskField;

    //    private annAnimeCreditCompany companyField;

    //    private uint gidField;

    //    /// <remarks/>
    //    public string task
    //    {
    //        get
    //        {
    //            return this.taskField;
    //        }
    //        set
    //        {
    //            this.taskField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    public annAnimeCreditCompany company
    //    {
    //        get
    //        {
    //            return this.companyField;
    //        }
    //        set
    //        {
    //            this.companyField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlAttributeAttribute()]
    //    public uint gid
    //    {
    //        get
    //        {
    //            return this.gidField;
    //        }
    //        set
    //        {
    //            this.gidField = value;
    //        }
    //    }
    //}

    ///// <remarks/>
    //[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    //public partial class annAnimeCreditCompany
    //{

    //    private ushort idField;

    //    private string valueField;

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlAttributeAttribute()]
    //    public ushort id
    //    {
    //        get
    //        {
    //            return this.idField;
    //        }
    //        set
    //        {
    //            this.idField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlTextAttribute()]
    //    public string Value
    //    {
    //        get
    //        {
    //            return this.valueField;
    //        }
    //        set
    //        {
    //            this.valueField = value;
    //        }
    //    }
    //}
    #endregion

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class ann
    {

        private annAnime[] animeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("anime")]
        public annAnime[] anime
        {
            get
            {
                return this.animeField;
            }
            set
            {
                this.animeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class annAnime
    {

        private annAnimeRelatedprev[] relatedprevField;

        private annAnimeRelatednext[] relatednextField;

        private annAnimeInfo[] infoField;

        private annAnimeRatings ratingsField;

        private annAnimeEpisode[] episodeField;

        private annAnimeReview reviewField;

        private annAnimeRelease[] releaseField;

        private annAnimeNews[] newsField;

        private annAnimeStaff[] staffField;

        private annAnimeCast[] castField;

        private annAnimeCredit[] creditField;

        private ushort idField;

        private uint gidField;

        private string typeField;

        private string nameField;

        private string precisionField;

        private System.DateTime generatedonField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("related-prev")]
        public annAnimeRelatedprev[] relatedprev
        {
            get
            {
                return this.relatedprevField;
            }
            set
            {
                this.relatedprevField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("related-next")]
        public annAnimeRelatednext[] relatednext
        {
            get
            {
                return this.relatednextField;
            }
            set
            {
                this.relatednextField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("info")]
        public annAnimeInfo[] info
        {
            get
            {
                return this.infoField;
            }
            set
            {
                this.infoField = value;
            }
        }

        /// <remarks/>
        public annAnimeRatings ratings
        {
            get
            {
                return this.ratingsField;
            }
            set
            {
                this.ratingsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("episode")]
        public annAnimeEpisode[] episode
        {
            get
            {
                return this.episodeField;
            }
            set
            {
                this.episodeField = value;
            }
        }

        /// <remarks/>
        public annAnimeReview review
        {
            get
            {
                return this.reviewField;
            }
            set
            {
                this.reviewField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("release")]
        public annAnimeRelease[] release
        {
            get
            {
                return this.releaseField;
            }
            set
            {
                this.releaseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("news")]
        public annAnimeNews[] news
        {
            get
            {
                return this.newsField;
            }
            set
            {
                this.newsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("staff")]
        public annAnimeStaff[] staff
        {
            get
            {
                return this.staffField;
            }
            set
            {
                this.staffField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("cast")]
        public annAnimeCast[] cast
        {
            get
            {
                return this.castField;
            }
            set
            {
                this.castField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("credit")]
        public annAnimeCredit[] credit
        {
            get
            {
                return this.creditField;
            }
            set
            {
                this.creditField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint gid
        {
            get
            {
                return this.gidField;
            }
            set
            {
                this.gidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string precision
        {
            get
            {
                return this.precisionField;
            }
            set
            {
                this.precisionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("generated-on")]
        public System.DateTime generatedon
        {
            get
            {
                return this.generatedonField;
            }
            set
            {
                this.generatedonField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class annAnimeRelatedprev
    {

        private string relField;

        private ushort idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string rel
        {
            get
            {
                return this.relField;
            }
            set
            {
                this.relField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class annAnimeRelatednext
    {

        private ushort idField;

        private string relField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string rel
        {
            get
            {
                return this.relField;
            }
            set
            {
                this.relField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class annAnimeInfo
    {

        private annAnimeInfoImg[] imgField;

        private string[] textField;

        private uint gidField;

        private bool gidFieldSpecified;

        private string typeField;

        private string srcField;

        private byte widthField;

        private bool widthFieldSpecified;

        private byte heightField;

        private bool heightFieldSpecified;

        private string langField;

        private string hrefField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("img")]
        public annAnimeInfoImg[] img
        {
            get
            {
                return this.imgField;
            }
            set
            {
                this.imgField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint gid
        {
            get
            {
                return this.gidField;
            }
            set
            {
                this.gidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool gidSpecified
        {
            get
            {
                return this.gidFieldSpecified;
            }
            set
            {
                this.gidFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string src
        {
            get
            {
                return this.srcField;
            }
            set
            {
                this.srcField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool widthSpecified
        {
            get
            {
                return this.widthFieldSpecified;
            }
            set
            {
                this.widthFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte height
        {
            get
            {
                return this.heightField;
            }
            set
            {
                this.heightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool heightSpecified
        {
            get
            {
                return this.heightFieldSpecified;
            }
            set
            {
                this.heightFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                this.langField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string href
        {
            get
            {
                return this.hrefField;
            }
            set
            {
                this.hrefField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class annAnimeInfoImg
    {

        private string srcField;

        private ushort widthField;

        private ushort heightField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string src
        {
            get
            {
                return this.srcField;
            }
            set
            {
                this.srcField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort height
        {
            get
            {
                return this.heightField;
            }
            set
            {
                this.heightField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class annAnimeRatings
    {

        private ushort nb_votesField;

        private decimal weighted_scoreField;

        private decimal bayesian_scoreField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort nb_votes
        {
            get
            {
                return this.nb_votesField;
            }
            set
            {
                this.nb_votesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal weighted_score
        {
            get
            {
                return this.weighted_scoreField;
            }
            set
            {
                this.weighted_scoreField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal bayesian_score
        {
            get
            {
                return this.bayesian_scoreField;
            }
            set
            {
                this.bayesian_scoreField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class annAnimeEpisode
    {

        private annAnimeEpisodeTitle[] titleField;

        private byte numField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("title")]
        public annAnimeEpisodeTitle[] title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte num
        {
            get
            {
                return this.numField;
            }
            set
            {
                this.numField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class annAnimeEpisodeTitle
    {

        private string partField;

        private uint gidField;

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string part
        {
            get
            {
                return this.partField;
            }
            set
            {
                this.partField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint gid
        {
            get
            {
                return this.gidField;
            }
            set
            {
                this.gidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                this.langField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class annAnimeReview
    {

        private string hrefField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string href
        {
            get
            {
                return this.hrefField;
            }
            set
            {
                this.hrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class annAnimeRelease
    {

        private System.DateTime dateField;

        private string hrefField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string href
        {
            get
            {
                return this.hrefField;
            }
            set
            {
                this.hrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class annAnimeNews
    {

        private System.DateTime datetimeField;

        private string hrefField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime datetime
        {
            get
            {
                return this.datetimeField;
            }
            set
            {
                this.datetimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string href
        {
            get
            {
                return this.hrefField;
            }
            set
            {
                this.hrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class annAnimeStaff
    {

        private string taskField;

        private annAnimeStaffPerson personField;

        private uint gidField;

        /// <remarks/>
        public string task
        {
            get
            {
                return this.taskField;
            }
            set
            {
                this.taskField = value;
            }
        }

        /// <remarks/>
        public annAnimeStaffPerson person
        {
            get
            {
                return this.personField;
            }
            set
            {
                this.personField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint gid
        {
            get
            {
                return this.gidField;
            }
            set
            {
                this.gidField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class annAnimeStaffPerson
    {

        private uint idField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class annAnimeCast
    {

        private string roleField;

        private annAnimeCastPerson personField;

        private uint gidField;

        private string langField;

        /// <remarks/>
        public string role
        {
            get
            {
                return this.roleField;
            }
            set
            {
                this.roleField = value;
            }
        }

        /// <remarks/>
        public annAnimeCastPerson person
        {
            get
            {
                return this.personField;
            }
            set
            {
                this.personField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint gid
        {
            get
            {
                return this.gidField;
            }
            set
            {
                this.gidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                this.langField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class annAnimeCastPerson
    {

        private uint idField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class annAnimeCredit
    {

        private string taskField;

        private annAnimeCreditCompany companyField;

        private uint gidField;

        /// <remarks/>
        public string task
        {
            get
            {
                return this.taskField;
            }
            set
            {
                this.taskField = value;
            }
        }

        /// <remarks/>
        public annAnimeCreditCompany company
        {
            get
            {
                return this.companyField;
            }
            set
            {
                this.companyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint gid
        {
            get
            {
                return this.gidField;
            }
            set
            {
                this.gidField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class annAnimeCreditCompany
    {

        private ushort idField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }


}
