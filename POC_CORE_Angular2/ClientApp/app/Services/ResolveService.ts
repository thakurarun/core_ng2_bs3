import { IMovieService, MovieService } from '../Services/MovieService';
import { MockMovieService } from '../Services/MockServices/MockMovieService';

export class ResolveService {
    
    public static get isMock(): boolean {
        return true;
    }

    static provide(token: any): any {
        return {
            provide: token, useClass: ((token: any) => {
                if (token!.name === 'IMovieService')
                    return ResolveService.isMock ? MockMovieService : MovieService;
                throw new Error(token!.name + " : not found.");
            })(token)
        }
    }
}