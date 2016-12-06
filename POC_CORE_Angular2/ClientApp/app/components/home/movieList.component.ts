import { Component, OnInit } from '@angular/core';

@Component({
    selector: 'movie-list', 
    template: require('./movieList.component.html')
})
export class MovieListComponent implements OnInit {
    constructor() { }

    ngOnInit() { }
}