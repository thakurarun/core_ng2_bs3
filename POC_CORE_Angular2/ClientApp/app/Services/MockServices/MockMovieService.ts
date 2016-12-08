import { Injectable } from '@angular/core';
var movieResult = require('./Data/movieResult.json');
import { MovieSearchResult } from '../../Model/MovieSearchResult';
import { MovieDTO } from '../../Model/DTO/MovieModel';
import { IMovieService } from '../MovieService';


export class MockMovieService implements IMovieService {
    constructor() {
    }

    getMovies(): Promise<MovieDTO[]> {
        return new Promise<MovieDTO[]>((onSuccess) => {
            onSuccess((movieResult as MovieSearchResult).movies);
        });
    }

}