import { Book } from "../models/book";
import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from "@angular/core";
import { Observable } from 'rxjs/Observable';

@Injectable()
export class BookService {
    private url: string = '/api/Books';
    constructor( private http: HttpClient) {
    }
    getBooks()
    {

        return this.http.get(this.url);
        //    .subscribe(result => {
        //    this.books = result.json() as Book[];
        //}, error => console.error(error));
    }
    getBook(id: number) {
        //let params = new HttpParams().set('id', id.toString());
        return this.http.get(this.url+"/"+id)
    }
    saveBook(book: Book) {
        this.http.post(this.url, book).subscribe();
    }
    updateBook(book: Book) {
        this.http.put(this.url, book).subscribe();
    }
}