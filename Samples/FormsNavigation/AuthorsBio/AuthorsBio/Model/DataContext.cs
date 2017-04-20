﻿using System;
namespace AuthorsBio.Model
{
    public static class DataContext
    {

        public static Author[] Database = {
            new Author {
                Id = 1,
                Name = "Franz Kafka",
                Bio = "Franz Kafka[a] (3 July 1883 – 3 June 1924) was a Prague German-language novelist and short story writer, widely regarded as one of the major figures of 20th-century literature. His work, which fuses elements of realism and the fantastic,[3] typically features isolated protagonists faced by bizarre or surrealistic predicaments and incomprehensible social-bureaucratic powers, and has been interpreted as exploring themes of alienation, existential anxiety, guilt, and absurdity.[4] His best known works include \"Die Verwandlung\" (\"The Metamorphosis\"), Der Process (The Trial), and Das Schloss (The Castle). The term Kafkaesque has entered the English language to describe situations like those in his writing.[5]\n\nKafka was born into a middle-class, German-speaking Jewish family in Prague, the capital of the Kingdom of Bohemia, then part of the Austro-Hungarian Empire, today part of the Czech Republic. He trained as a lawyer, and after completing his legal education he was employed with an insurance company, forcing him to relegate writing to his spare time. Over the course of his life, Kafka wrote hundreds of letters to family and close friends, including his father, with whom he had a strained and formal relationship. He became engaged to several women but never married. He died in 1924 at the age of 40 from tuberculosis.\n\nFew of Kafka's works were published during his lifetime: the story collections Betrachtung (Contemplation) and Ein Landarzt (A Country Doctor), and individual stories (such as \"Die Verwandlung\") were published in literary magazines but received little public attention. Kafka's unfinished works, including his novels Der Process, Das Schloss and Amerika (also known as Der Verschollene, The Man Who Disappeared), were ordered by Kafka to be destroyed by his friend Max Brod, who nonetheless ignored his friend's direction and published them after Kafka's death. His work went on to influence a vast range of writers, critics, artists, and philosophers during the 20th century.",
                PictureUrl = "https://upload.wikimedia.org/wikipedia/commons/4/4c/Kafka1906_cropped.jpg",
                WikipediaUrl = "https://en.wikipedia.org/wiki/Franz_Kafka",
            },
			new Author {
				Id = 2,
				Name = "Gabriel García Márquez",
				Bio = "Gabriel José de la Concordia García Márquez (/ɡɑːrˈsiːə ˈmɑːrkɛs/;[6] American Spanish: [ɡaˈβɾjel ɣarˈsi.a ˈmarkes] ( listen);[7] 6 March 1927 – 17 April 2014) was a Colombian novelist, short-story writer, screenwriter and journalist, known affectionately as Gabo or Gabito throughout Latin America. Considered one of the most significant authors of the 20th century and one of the best in the Spanish language, he was awarded the 1972 Neustadt International Prize for Literature and the 1982 Nobel Prize in Literature.[8] He pursued a self-directed education that resulted in his leaving law school for a career in journalism. From early on, he showed no inhibitions in his criticism of Colombian and foreign politics. In 1958, he married Mercedes Barcha; they had two sons, Rodrigo and Gonzalo.[9]\n\nGarcía Márquez started as a journalist, and wrote many acclaimed non-fiction works and short stories, but is best known for his novels, such as One Hundred Years of Solitude (1967), The Autumn of the Patriarch (1975), and Love in the Time of Cholera (1985). His works have achieved significant critical acclaim and widespread commercial success, most notably for popularizing a literary style labeled as magic realism, which uses magical elements and events in otherwise ordinary and realistic situations. Some of his works are set in a fictional village called Macondo (the town mainly inspired by his birthplace Aracataca), and most of them explore the theme of solitude.\n\nOn his death in April 2014, Juan Manuel Santos, the President of Colombia, described him as \"the greatest Colombian who ever lived.\"[10]",
				PictureUrl = "http://www.langolodeilibri.it/wp-content/uploads/2014/04/Gabriel-Garcia-Marquez-1.jpg",
				WikipediaUrl = "https://en.wikipedia.org/wiki/Gabriel_Garc%C3%ADa_M%C3%A1rquez",
			},
			new Author {
				Id = 3,
				Name = "George Orwell",
				Bio = "Eric Arthur Blair (25 June 1903 – 21 January 1950),[1] better known by his pen name George Orwell, was an English novelist, essayist, journalist, and critic. His work is marked by lucid prose, awareness of social injustice, opposition to totalitarianism, and outspoken support of democratic socialism.[2][3]\n\nOrwell wrote literary criticism, poetry, fiction, and polemical journalism. He is best known for the allegorical novella Animal Farm (1945) and the dystopian novel Nineteen Eighty-Four (1949). His non-fiction works, including The Road to Wigan Pier (1937), documenting his experience of working class life in the north of England, and Homage to Catalonia (1938), an account of his experiences in the Spanish Civil War, are widely acclaimed, as are his essays on politics, literature, language, and culture. In 2008, The Times ranked him second on a list of \"The 50 greatest British writers since 1945\".[4]\n\nOrwell's work continues to influence popular and political culture, and the term Orwellian – descriptive of totalitarian or authoritarian social practices – has entered the language together with many of his neologisms, including cold war, Big Brother, Thought Police, Room 101, memory hole, newspeak, doublethink, and thoughtcrime.[5]",
				PictureUrl = "https://upload.wikimedia.org/wikipedia/commons/7/7e/George_Orwell_press_photo.jpg",
				WikipediaUrl = "https://en.wikipedia.org/wiki/George_Orwell",
			},
			new Author {
				Id = 4,
				Name = "José Saramago",
				Bio = "Novelist, playwright, and poet José Saramago was a child of Portuguese peasants, raised in poverty in France, who learned of literature through visits to the public library as often as his parents would allow. His first novel, published in 1947, was not a popular success, and after finishing a second novel, never published, he concluded that he simply had nothing to say and gave up on writing. He supported his family with manual labor, eventually finding positions as an office manager for a publisher, a newspaper editor, a translator of foreign authors' work, and a political commentator. Nearly two decades passed before another book with his byline appeared, a small collection of his poems published to no acclaim in 1966.\n\nHe was a life-long Communist, and at serious risk to his safety Saramago became an outspoken leader of the 1974 Carnation Revolution (named for the flowers carried by protesters in lieu of violent action), which toppled the Portuguese dictatorship and installed a democratic government. His breakthrough success came with the blasphemous Baltasar and Blimunda, a 1982 novel about an 18th century romance between an injured soldier and a young clairvoyant. A widely acknowledged masterpiece was his 1984 novel The Year of the Death of Ricardo Reis, which resurrected the titular character from Fernando Pessoa's fiction and set him amidst the Spanish Civil War and the rise of such tyrants as Adolf Hitler, Benito Mussolini, Francisco Franco, and António de Oliveira Salazar. Arguably his best known work, 1991's The Gospel According to Jesus Christ, tells the familiar New Testament story with the twist that Christ was the son of Joseph, not God.\n\nHis works were frequently considered controversial, with good reason. He took delight in treading on delicate sensibilities far beyond Portugal's politics, with subversive but often humorous observations on the Vatican, globalization, ecological destruction, social injustice, the heartlessness of bureaucracy, and the cruelty of human greed. He was awarded the Nobel Prize for Literature in 1998, after which his readership was vastly increased.\n\nOf his Nobel win, The New York Times pronounced that \"No candidate for a Nobel Prize has a better claim to lasting recognition than this novelist\", while the Wall Street Journal complained about his \"Stalinist past\" and the Vatican's official newspaper described him, accurately, as an \"inveterate communist with anti-religious views\". His Nobel accolade included a cash award of about $950K, of which Saramago said, \"This prize is for all speakers of Portuguese, but while we're on the subject, I shall keep the money\". He died in 2010.",
				PictureUrl = "http://www.nndb.com/people/608/000035503/jose-saramago-1-sized.jpg",
				WikipediaUrl = "https://en.wikipedia.org/wiki/Jos%C3%A9_Saramago",
			},
			new Author {
				Id = 5,
				Name = "Aldous Huxley",
				Bio = "Aldous Huxley is an English writer best know for his dystopian novel \"Brave New World\" written in 1931.\n\nIn 1937, Aldous Huxley moved to California to escape the impending WWII, to work in Hollywood, and he believed that the California climate would help his eyesight.\n\nHuxley worked on films in the 1940s and 1950s his best known screenplays are \"Pride and Prejudice\" (1940), \"Jane Eyre\" (1943), and \"Alice in Wonderland\" (1950).\n\nThis collection includes the CBS Radio Workshop version of most well known work \"Brave New World\" narrated by Aldous Huxley himself.\n\nAldous HuxleyLux Radio Theater produced Aldous Huxley's \"Jane Eyre.\" This collection also included a fascinating Mike Wallace interview, and scripts he wrote for Molle Mystery Theater, NBC University Theater, The New Theater and This I Believe.",
				PictureUrl = "https://www.otrcat.com/images/aldous+huxley.jpg",
				WikipediaUrl = "https://en.wikipedia.org/wiki/Aldous_Huxley",
			},
		};
    
    }
}
