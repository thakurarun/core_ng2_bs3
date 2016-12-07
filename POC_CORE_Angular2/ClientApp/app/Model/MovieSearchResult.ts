import { MovieDTO } from './DTO';

export interface ResultModel {
    isSuccess: boolean;
    message: string;
    preserveData: any;
}

export interface MovieSearchResult extends ResultModel {
    movies: MovieDTO[]
}