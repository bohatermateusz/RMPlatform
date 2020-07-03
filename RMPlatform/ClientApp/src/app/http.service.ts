import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';


@Injectable()
export class HttpService {

constructor(private http: HttpClient) { }

url = 'https://localhost:44320/weatherforecast';
 

getPost(): Observable<Array<Get>>
{
 return this.http.get<Array<Get>>(this.url);
}

}

export interface Get {
departmentID?: number;
name?: string;
enrollments?: string;
}


