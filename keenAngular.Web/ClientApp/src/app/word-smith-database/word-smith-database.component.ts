import { Component, Inject } from "@angular/core";
import { HttpClient } from "@angular/common/http";

import { IWords } from "../models/word-smith/words";

@Component({
    templateUrl: "./word-smith-database.component.html",
})
export class WordSmithWordsComponent {
    public words: IWords[];

    constructor(http: HttpClient, @Inject("BASE_URL") baseUrl: string) {
        //http.get<IWords[]>(baseUrl + "api/WordSmith/GetAllWords").subscribe(result => {
        http.get<IWords[]>("http://localhost:16510/" + "api/WordSmithWords/GetWordSmithWords").subscribe(result => {
            this.words = result;
            console.log(result);

            console.log("this.words are: " + JSON.stringify(this.words));
        },error => console.error(error));
    }
}
