export interface MovieDTO {
    id: number;
    url: string;
    imdb_code: string
    title: string;
    year: number;
    rating: number;
    runtime: number;
    genres: string[];
    summary: string;
    description_full: string;
    language: string;
    mpa_rating: string;
    background_image: string;
    background_image_original: string;
    small_cover_image: string;
    medium_cover_image: string;
    large_cover_image: string;
    state: string;
    torrents: TorrentDTO[];
    date_uploaded_unix: number;
}

export interface TorrentDTO {
    url: string;
    hash: string;
    quality: string;
    seeds: number;
    peers: number;
    size: string;
    size_bytes: number;
    date_uploaded: string;
    date_uploaded_unix: number;
}