import { Category } from '../common/classes/category.class';

export const CATEGORIES: Category[] = [
  new Category(1, '1. Kategorie', 'Raum 1', 10),
  { id: 2, name: '2. Kategorie', comment: 'Raum 1', deviceCount: 14 },
  { id: 3, name: '3. Kategorie', comment: 'Raum 2', deviceCount: 14 },
  { id: 4, name: '4. Kategorie', comment: 'Raum 2', deviceCount: 14 }
];
