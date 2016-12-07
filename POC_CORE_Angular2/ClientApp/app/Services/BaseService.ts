import { Http, Response } from '@angular/http';
import 'rxjs/add/operator/toPromise';

export abstract class BaseService {

    private get BASE_URL(): string { return 'http://localhost:51603/api/'; }

    constructor(private http: Http) {
    }

    protected get<T>(query: string): Promise<T> {
        let url = this.BASE_URL + query;
        return this.http.get(url).toPromise().then((res:Response)=>{
            return res.json() as T;
        });
    }


}