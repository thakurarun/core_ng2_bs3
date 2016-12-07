import { Injectable } from '@angular/core';
import { Http } from '@angular/http';
import { BaseService } from './BaseService';

import { MovieSearchResult } from '../Model/MovieSearchResult';
import { MovieDTO } from '../Model/DTO/MovieModel';

export abstract class IMovieService {
    abstract getMovies(): Promise<MovieDTO[]>;
}

@Injectable()
export class MovieService extends BaseService implements IMovieService {
    constructor(private _http: Http) {
        super(_http);
    }

    getMovies(): Promise<MovieDTO[]> {
        let query: string = 'Movies';
        return this.get<MovieSearchResult>(query)
            .then((res: MovieSearchResult) => {
                return res.movies;
            });
    }

}