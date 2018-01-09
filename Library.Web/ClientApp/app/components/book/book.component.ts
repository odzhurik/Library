import { Component, Inject, OnInit, ViewChild } from '@angular/core';
import { Book } from "../../models/book";
import { Http } from '@angular/http';
import { BookService } from '../../services/book.service';
import { BsModalComponent } from 'ng2-bs3-modal/ng2-bs3-modal'
//import { Ng2Bs3ModalModule } from 'ng2-bs3-modal/ng2-bs3-modal';
//declare var jQuery: any;
//import * as jQuery from 'jquery';
import { Observable } from 'rxjs/Observable';
import 'rxjs/Rx';

@Component({
    selector: 'book',
    templateUrl: './book.component.html',
    providers: [BookService]
})
export class BookComponent implements OnInit {
    @ViewChild('modal') modal : BsModalComponent;
    public books: Book[];
    public book: Book = new Book(0, "", "", 0);
    constructor(private bookService: BookService) {
        this.books = new Array<Book>();
    }
    ngOnInit() {
        // this.modal.hiding = true;
       // this.modal.hiding = true;
        this.bookService.getBooks().subscribe(data => {
            // Read the result field from the JSON response.
            this.books = data as Book[];
          //  .subscribe((value: Book[]) => {
          // this.books = value;
       });
    }
    showAddModal() {
        
        this.modal.open();
    }

    addBook()
    {
        this.bookService.saveBook(this.book);
        this.modal.close();
    }
}