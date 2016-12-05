import { Component, OnInit, Input } from '@angular/core';

@Component({
    selector: 'search-text',
    template: require('./search.component.html')
})
export class SearchComponent implements OnInit {
    @Input()
    field: string;
    constructor() { }

    ngOnInit() { }
}