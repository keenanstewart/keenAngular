export interface IWords
{
    id: number;
    wordThemeID: number;
    dailyWord: string;
    pronunciation: string;
    meaning: string;
    etymology: string;
    usage: string;
    thoughtADay: string;
    notes: string;
    inputDate: Date;
    updateDate: Date;
    reviewed: boolean;
}
