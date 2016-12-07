import { Component, OnInit } from '@angular/core';
import { IMovieService } from '../../Services/MovieService';
import { ResolveService } from '../../Services/ResolveService';

import { MovieDTO } from '../../Model/DTO/MovieModel';
@Component({
    selector: 'movie-list',
    template: require('./movieList.component.html'),
    providers: [
        ResolveService.provide(IMovieService)
    ],
    styles: [require('./movieList.style.css')]
})
export class MovieListComponent implements OnInit {
    movies: MovieDTO[];
    constructor(private service: IMovieService) {

    }

    ngOnInit() {
        this.service.getMovies().then((movies) => {
            this.movies = movies;
        });
    }
}