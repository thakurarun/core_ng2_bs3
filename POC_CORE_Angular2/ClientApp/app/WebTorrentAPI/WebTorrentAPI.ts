var WebTorrent = require('webtorrent')

import { TorrentDTO } from '../Model/DTO/MovieModel';
export class WebTorrentAPI {
    readonly torrentId: string = 'magnet:?xt=urn:btih:6a9759bffd5c0af65319979fb7832189f4f3c35d&dn=sintel.mp4&tr=wss%3A%2F%2Ftracker.btorrent.xyz&tr=wss%3A%2F%2Ftracker.fastcast.nz&tr=wss%3A%2F%2Ftracker.openwebtorrent.com&ws=https%3A%2F%2Fwebtorrent.io%2Ftorrents%2Fsintel-1024-surround.mp4'
    constructor(private torrent: TorrentDTO) {
    }

    StartDownload() {
        var client = new WebTorrent();

        client.add(this.torrentId, function (torrent) {
            // Torrents can contain many files. Let's use the first.
            var file = torrent.files[0]
            debugger;
            // Display the file by adding it to the DOM. Supports video, audio, image, etc. files
            file.appendTo('body')
        })
    }
}