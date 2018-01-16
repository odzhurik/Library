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
    public title: string;
    public isAddMode: boolean;
    constructor(private bookService: BookService) {   
    }
    ngOnInit() {        
        this.loadBooks();
    }
    showAddModal() {
        this.isAddMode = true;
        this.title = "Add";
        this.modal.open();
    }
    showEditModal(id: number) {
        
        this.bookService.getBook(id).subscribe(data => {
            this.book = data as Book;
        }
        );
        this.isAddMode = false;
        this.title = "Edit";
        this.modal.open();
    }
    addBook()
    {
        this.bookService.saveBook(this.book);
        this.modal.close();
        this.loadBooks();
    }
    updateBook() {

        this.bookService.updateBook(this.book);
        this.modal.close();
        this.loadBooks();
    }

    private loadBooks() {
        this.bookService.getBooks().subscribe(data => {            
            this.books = data as Book[];     
           });
    }
}