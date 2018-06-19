import { Component, Inject } from "@angular/core";
import { HttpClient } from "@angular/common/http";

import { IWords } from "../models/word-smith/words";

@Component({
    selector: "app-fetch-data",
    templateUrl: "./word-smith.component.html",
})
export class WordSmithComponent {
    public words: IWords[];

    constructor(http: HttpClient, @Inject("BASE_URL") baseUrl: string) {
        //http.get<IWords[]>(baseUrl + "api/WordSmith/GetAllWords").subscribe(result => {
        http.get<IWords[]>("http://localhost:16510/" + "api/WordSmith/GetAllWords").subscribe(result => {
        this.words = result;
    }, error => console.error(error));
    }
}
