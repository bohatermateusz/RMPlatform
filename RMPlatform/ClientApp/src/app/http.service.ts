import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';


@Injectable()
export class HttpService {

constructor(private http: HttpClient) { }

url = 'https://jsonplaceholder.typicode.com/posts';


getPost(): Observable<Array<Post>>
{
 return this.http.get<Array<Post>>(this.url);
}

}

export interface Post {
userId?: number;
id?: number;
title?: string;
body?: string;
}


