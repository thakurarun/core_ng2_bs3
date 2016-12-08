var WebTorrent = require('webtorrent')

import { TorrentDTO } from '../Model/DTO/MovieModel';
export class WebTorrentAPI {
    // readonly torrentId: string = 'magnet:?xt=urn:btih:6a9759bffd5c0af65319979fb7832189f4f3c35d&dn=sintel.mp4&tr=wss%3A%2F%2Ftracker.btorrent.xyz&tr=wss%3A%2F%2Ftracker.fastcast.nz&tr=wss%3A%2F%2Ftracker.openwebtorrent.com&ws=https%3A%2F%2Fwebtorrent.io%2Ftorrents%2Fsintel-1024-surround.mp4'
    private torrentId: string;
    constructor(private torrent: TorrentDTO) {
        //this.torrentId = 'magnet:?xt=urn:btih:'+ torrent.hash;
        this.torrentId = 'magnet:?xt=urn:btih:531CC2B3DD07FD5B31CA5CB5FDDE5A2123DBE547&dn=Beware!%20The%20Blob%20(1972)%20%5BYTS.AG%5D&tr=udp%3A%2F%2Ftracker.openbittorrent.com%3A80&tr=udp%3A%2F%2Fopentor.org%3A2710&tr=udp%3A%2F%2Ftracker.ccc.de%3A80&tr=udp%3A%2F%2Ftracker.blackunicorn.xyz%3A6969&tr=udp%3A%2F%2Ftracker.coppersurfer.tk%3A6969&tr=udp%3A%2F%2Ftracker.leechers-paradise.org%3A6969';
    }

    StartDownload() {
        var client = new WebTorrent();
        debugger;
        client.add(this.torrentId, function (torrent) {
            // Torrents can contain many files. Let's use the first.
            var file = torrent.files[0]

            // Display the file by adding it to the DOM. Supports video, audio, image, etc. files
            file.appendTo('body')
        })
    }
}

//magnet:?xt=urn:btih:6a9759bffd5c0af65319979fb7832189f4f3c35d