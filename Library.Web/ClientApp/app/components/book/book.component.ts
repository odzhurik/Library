import { Component, Inject } from '@angular/core';
import { Book } from "../../models/book";
import { Http } from '@angular/http';

@Component({
    selector: 'book',
    templateUrl: './book.component.html'
})
export class BookComponent {
    public books: Book[];

    constructor(http: Http) {
        http.get('/api/Books').subscribe(result => {
            this.books = result.json() as Book[];
        }, error => console.error(error));
    }
}