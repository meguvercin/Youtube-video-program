# Youtube-video-program
Youtube-video program

## Total Actual Duration:
15 hours

### View Admin
![View Admin)](https://github.com/meguvercin/Youtube-video-program/assets/105549919/952fb5a6-47b1-4629-aeee-9cd9be653784)

### Main Page
![Main Page](https://github.com/meguvercin/Youtube-video-program/assets/105549919/b3358e41-51d6-4315-9661-8b35579b55f1)

### Update Page
![Update Page)](https://github.com/meguvercin/Youtube-video-program/assets/105549919/a5274434-8458-4703-9c33-faaaa0b5a093)

### Add Video
![Add Video](https://github.com/meguvercin/Youtube-video-program/assets/105549919/9e55b707-9a2b-4e30-971a-91712d87e89e)

## Text Files Final Status:
- Screenshot
![video.csv)](https://github.com/meguvercin/Youtube-video-program/assets/105549919/ebc5e71c-c08e-4886-be74-a803d7d70e2a) and ![admin.csv)](https://github.com/meguvercin/Youtube-video-program/assets/105549919/92bf86e8-a1b2-4541-b8ff-a46327525622) files



## Project Description
This project is a video management portal. It allows users to perform the following operations:
- List videos
- Add new videos
- Edit existing videos
- Delete videos
- View video details

### Features
1. **Authentication**: 
   - Users must log in using credentials stored in `admin.csv`.
   - If the username and password are correct, users are redirected to the main dashboard.
   - If incorrect, an error message is displayed.

2. **Main Dashboard (Form2.cs)**:
   - Lists all videos from `video.csv` that are not marked as deleted.
   - Displays selected video details.
   - Includes a timer that refreshes the video list every 15 seconds.
   - Shows the count of saved and deleted videos, and the last update time.

3. **Video Details**:
   - When a video is selected, its details are shown.
   - Thumbnail is displayed using the URL `https://img.youtube.com/vi/<insert-youtube-video-id-here>/default.jpg`.
   - Clicking the thumbnail or the "Open" button opens the video in the default browser.
   - Allows updating and deleting video information.

4. **Add New Video (Form3.cs)**:
   - Validates input fields.
   - Adds new video records to `video.csv`.

5. **Edit Video (Form4.cs)**:
   - Pre-fills fields with selected video information.
   - Validates and updates video records in `video.csv`.
